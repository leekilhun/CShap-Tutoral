using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exFrameModeling
{
    public partial class Form1 : Form
    {
        #region 전역 변수
        ucPanel.ucScreen1 ucSc1 = new ucPanel.ucScreen1(); // 화면1 
        ucPanel.ucScreen2 ucSc2 = new ucPanel.ucScreen2(); // 화면2
        ucPanel.ucScreen3 ucSc3 = new ucPanel.ucScreen3(); // 화면3
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region Form Event
        private void Form1_Load(object sender, EventArgs e)
        {
            ucSc1.eLogSender += UcSc_eLogSender;   // 화면 1 Delegate Event
            ucSc2.eLogSender += UcSc_eLogSender;   // 화면 1 Delegate Event
            ucSc3.eLogSender += UcSc_eLogSender;   // 화면 1 Delegate Event

            pMain.Controls.Add(ucSc1);
        }

        // Main 화면 Button Click Event (동일 Event로 받고 코드 상에서 분기 처리)
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "BtnSc1":
                    pMain.Controls.Clear();
                    pMain.Controls.Add(ucSc1);
                    break;
                case "BtnSc2":
                    pMain.Controls.Clear();
                    pMain.Controls.Add(ucSc2);
                    break;
                case "BtnSc3":
                    pMain.Controls.Clear();
                    pMain.Controls.Add(ucSc3);
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
            DateTime dTime = DateTime.Now;
            string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
            lboxLog.Items.Insert(0, LogInfo);
        }
        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        {
            string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
            lboxLog.Items.Insert(0, LogInfo);
        }
        #endregion


    }
}
