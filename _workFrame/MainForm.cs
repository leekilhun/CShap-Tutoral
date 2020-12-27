using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using workFrame.form;
using workFrame.modules;

namespace workFrame
{
    public partial class MainForm : Form
    {
        #region 전역 변수

        private static CRobot mRobot;  // Robot Class
        private static CDoor mDoor1, mDoor2;  // Door Class


        public static CRobot MRobot { get => mRobot; }
        public static CDoor MDoor1  { get => mDoor1; }
        public static CDoor MDoor2  { get => mDoor2; }


        private formAuto fAuto =    new formAuto();
        private formManual fManual = new formManual();
        private formData fData = new formData();

        private Form currentChildForm;

        public static bool[] Flags = new bool[1028];

        private MCylinder[] Cylinder;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Form Event
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form Load 시점에 Class 생성

            fAuto.eLogSender += UcSc_eLogSender;
            fManual.eLogSender += UcSc_eLogSender;
            fData.eLogSender += UcSc_eLogSender;

            writeProgramInfor();           

            Initial();
            OpenChildForm(fAuto);
        }

        #region 테스트 하는 곳

        private int factor;


        //public CRobot GetCRobot () 
        //{ 
        //    return mRobot;
        //}

        public void Example(int f)
        {
            factor = f;
        }

        public int SampleMethod(int x)
        {
            Console.WriteLine("\nExample.SampleMethod({0}) executes.", x);
            return x * factor;
        }

        #endregion //테스트
        private void writeProgramInfor()
        {
            Assembly assem = typeof(MainForm).Assembly;            

            Version oVersion = assem.GetName().Version;

            Console.WriteLine("Assembly Full Name:");
            Console.WriteLine(assem.FullName);

            // The AssemblyName type can be used to parse the full name.
            AssemblyName assemName = assem.GetName();
            Console.WriteLine("\nName: {0}", assemName.Name);
            Console.WriteLine("Version: {0}.{1}", assemName.Version.Major, assemName.Version.Minor);

            Console.WriteLine("\nAssembly CodeBase:");
            Console.WriteLine(assem.CodeBase);

            // Create an object from the assembly, passing in the correct number
            // and type of arguments for the constructor.
            Object o = assem.CreateInstance("workFrame.MainForm.Example", false,
                BindingFlags.ExactBinding,
                null, new Object[] { 2 }, null, null);

            // Make a late-bound call to an instance method of the object.
            Type t = assem.GetType("workFrame.MainForm");
            MethodInfo m = t.GetMethod("SampleMethod");

            Console.WriteLine("\nAssembly entry point:");
            Console.WriteLine(assem.EntryPoint);

            this.Text = string.Format("{0} Ver.{1}.{2} / Build Time ({3}) - {4}", "Machine Control Panel", oVersion.Major, oVersion.Minor, GetBuildDataTime(oVersion), "프로그램 상태");

            GetBuildDataTime(oVersion);

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Initial()
        {
            //CylData[] cData = new CylData[2]
            //{
            //    new CylData( 1,1,"LeftDoorUpDown"),
            //    new CylData( 2,2,"RightDoorUpDown")
            //};

            CylinderData[] cDataClass = new CylinderData[2]
            {
                new CylinderData( cylinder.LeftDoor_UpDown,cylinder.LeftDoor_UpDown.ToString(),11,12,1.0,1.5),
                new CylinderData( cylinder.RightDoor_UPDown,cylinder.RightDoor_UPDown.ToString(),21,22,1.0,1.5)
            };


            Cylinder = new MCylinder[2]
            {
                new MCylinder(1,cDataClass[0]),
                new MCylinder(2,cDataClass[1])
            };


            mRobot = new CRobot("Robot");
           // fAuto.
            mDoor1 = new CDoor("DoorLeft", Cylinder[0]);
            mDoor2 = new CDoor("DoorRight", Cylinder[1]);


        }

        
        private void assignComponents()
        {

        }

    

        public DateTime GetBuildDataTime(Version oVersion)
        {
            string strVerstion = oVersion.ToString();

            // 날짜 등록
            int iDays = Convert.ToInt32(strVerstion.Split('.')[2]);
            DateTime refData = new DateTime(2000, 1, 1);
            DateTime dtBuildDate = refData.AddDays(iDays);

            // 초 등록
            int iSeconds = Convert.ToInt32(strVerstion.Split('.')[3]);
            iSeconds = iSeconds * 2;
            dtBuildDate = dtBuildDate.AddSeconds(iSeconds);

            // 시차 조정
            DaylightTime daylighttime = TimeZone.CurrentTimeZone.GetDaylightChanges(dtBuildDate.Year);

            if (TimeZone.IsDaylightSavingTime(dtBuildDate, daylighttime))
            {
                dtBuildDate = dtBuildDate.Add(daylighttime.Delta);
            }


            return dtBuildDate;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pMain.Controls.Add(childForm);
            pMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }


        // Main 화면 Button Click Event (동일 Event로 받고 코드 상에서 분기 처리)
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "BtnSc1":
                    //pMain.Controls.Clear();
                    OpenChildForm(fAuto);
                    break;
                case "BtnSc2":
                    //pMain.Controls.Clear();
                    OpenChildForm(fManual);
                    break;
                case "BtnSc3":
                    // pMain.Controls.Clear();
                    //pMain.Controls.Add(ucSc3);
                    OpenChildForm(fData);
                    break;
                case "BtnExit":
                    Application.Exit();
                    break;
                default:
                    break;
            }

            Log(enLogLevel.Info, $"{btn.Text} 버튼 Click");
        }
        #endregion

        #region del Event
        private void UcSc_eLogSender(object oSender, enLogLevel eLevel, string strLog)
        {
            Log(eLevel, $"[{oSender.ToString()}] {strLog}");
        }
        #endregion










        #region Log OverLoading
        private void Log(enLogLevel eLevel, string LogDesc)
        {
            if (this.InvokeRequired)   // 요청 한 Thread가 현재 Main Thread 있는 Contorl을 엑세스 할 수 있는지 확인
            {

                this.Invoke(new Action(delegate ()
                {
                    DateTime dTime = DateTime.Now;
                    string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                    lboxLog.Items.Insert(0, LogInfo);
                }));
            }
        }

      

        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        {
            /**
            if (this.InvokeRequired)   // 요청 한 Thread가 현재 Main Thread 있는 Contorl을 엑세스 할 수 있는지 확인
            {

                this.Invoke(new Action(delegate ()
                {
                   ///
                }));
            }
            **/
            if (this.InvokeRequired)   // 요청 한 Thread가 현재 Main Thread 있는 Contorl을 엑세스 할 수 있는지 확인
            {

                this.Invoke(new Action(delegate ()
                {
                    string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                    lboxLog.Items.Insert(0, LogInfo);
                }));
            }
            
        }
        #endregion


    }
}
