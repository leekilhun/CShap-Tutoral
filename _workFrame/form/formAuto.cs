using workFrame.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using workFrame.modules;

namespace workFrame.form
{
    public partial class formAuto : Form
    {
        CRobot _cRobot;  // Robot Class
        CDoor _cDoor1, _cDoor2;  // Door Class
        int _iRobot_Rotate = 0;  // Robot Rotate
        int _iSpeed = 100;  // Thread Sleep Time
        bool _bObjectExist = false;   // Robot이 Object를 가지고 있는지 여부

        public event delLogSender eLogSender;

        public formAuto()
        {
            InitializeComponent();
        }


        private void formAuto_Load(object sender, EventArgs e)
        {
            _cRobot = MainForm.MRobot;     //new CRobot("Robot");
            _cDoor1 = MainForm.MDoor1;
            _cDoor2 = MainForm.MDoor2;
        }

        private void formAuto_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        /// <summary>
        /// 상태가 틀어 졌을 경우 초기 상태를 맞춰 주기 위해 추가
        /// </summary>
        private void initDraw()
        {
            _iRobot_Rotate = 0;

            _cRobot.Initialize();
            _cDoor1.Initialize();
            _cDoor2.Initialize();

            fRobotDraw(_iRobot_Rotate, 0, false);
            fDoor1Draw(0);
            fDoor2Draw(0);
        }

        /// <summary>
        /// Panel에 Robot을 Draw
        /// </summary>
        /// <param name="iRotate"></param>
        /// <param name="iRobot_Arm_Move"></param>
        /// <param name="isObject"></param>
        private void fRobotDraw(int iRotate, int iRobot_Arm_Move, bool isObject)
        {
            this.Invoke(new Action(delegate ()
            {
                pRobot.Refresh();

                Graphics g = pRobot.CreateGraphics();

                g.FillEllipse(_cRobot.fBrushInfo(), _cRobot._rtCircle_Robot);

                _cRobot.fMove(iRobot_Arm_Move);

                Point center = new Point(100, 100);
                g.Transform = GetMatrix(center, iRotate);

                g.DrawRectangle(_cRobot.fPenInfo(), _cRobot._rtSquare_Arm);

                // Object가 있을 경우 표시 하고 없을 경우 표시 하지 않음
                if (isObject)
                {
                    g.FillRectangle(_cRobot.fBrushInfo(), _cRobot._rtSquare_Object);
                }
            }));
        }

        /// <summary>
        /// Panel에 Door 1을 Draw
        /// </summary>
        /// <param name="Move"></param>
        private void fDoor1Draw(int Move)
        {
            this.Invoke(new Action(delegate ()
            {
                pDoor1.Refresh();

                _cDoor1.fMove(Move);

                Graphics g = pDoor1.CreateGraphics();

                g.FillRectangle(_cDoor1.fBrushInfo(), _cDoor1._rtDoor);
                g.DrawRectangle(_cDoor1.fPenInfo(), _cDoor1._rtDoorSide);
            }));
        }

        /// <summary>
        /// Panel에 Door 2를 Draw
        /// </summary>
        /// <param name="Move"></param>
        private void fDoor2Draw(int Move)
        {
            this.Invoke(new Action(delegate ()
            {
                pDoor2.Refresh();

                _cDoor2.fMove(Move);

                Graphics g = pDoor2.CreateGraphics();

                g.FillRectangle(_cDoor2.fBrushInfo(), _cDoor2._rtDoor);
                g.DrawRectangle(_cDoor2.fPenInfo(), _cDoor2._rtDoorSide);
            }));
        }


        // Robot 회전 시 사용 하는 함수 (실제 Robot이 회전하는게 아니고 Robot Arm을 Robot 중심 기준으로 회전 시킴)
        private Matrix GetMatrix(Point centerPoint, float rotateAngle)
        {
            Matrix matrix = new Matrix();

            matrix.RotateAt(rotateAngle, centerPoint);

            return matrix;
        }

        /// <summary>
        /// 비동기 제어 : 함수 호출 시 Task를 생성 해서 비동기로 진행 하나 필요에 따라 await를 가지고 함수의 종료를 대기
        /// </summary>
        private async void Start_Move_Async()
        {
            eLogSender("Auto",enLogLevel.Info, "Move Async Sequence Start");

            // 동시 동작 하는 부분의 경우 긴 시간 기준으로 대기 하도록 함
            Task vTask;

            vTask = Task.Run(() => RobotArmExtend());
            await Task.Run(() => Door1Open());

            Thread.Sleep(500);
            _bObjectExist = true;  // 팔을 뻗고 물건을 가지고 나오고
            await Task.Run(() => RobotArmRetract());

            vTask = Task.Run(() => Door1Close());
            await Task.Run(() => Call_RobotRotate());

            vTask = Task.Run(() => RobotArmExtend());
            await Task.Run(() => Call_Door2Open());

            Thread.Sleep(500);
            _bObjectExist = false;  // 팔을 뻗고 물건을 가지고 나오고
            await Task.Run(() => RobotArmRetract());

            vTask = Task.Run(() => Door2Close());
            await Task.Run(() => Call_RobotRotate());

            eLogSender("Auto", enLogLevel.Info, "Move Async Sequence Complete");


            /*
            //Call_RobotArmExtend();
            //await Call_Door1Open();

            Thread.Sleep(500);
            _bObjectExist = true;  // 팔을 뻗고 물건을 가지고 나오고
            await Call_RobotArmRetract();

            Call_Door1Close();
            await Call_RobotRotate();

            Call_RobotArmExtend();
            await Call_Door2Open();

            Thread.Sleep(500);
            _bObjectExist = false;  // 팔을 뻗고 물건을 놔두고 나옴
            await Call_RobotArmRetract();

            Call_Door2Close();
            await Call_RobotRotate();
            */
        }



        #region 비동기 호출 Call 함수 (필요 없지만 참고용으로 사용)

        private Task<int> Call_Door1Open()
        {
            var vTask = Task.Run(() => Door1Open());

            return vTask;
        }


        private Task<int> Call_Door1Close()
        {
            var vTask = Task.Run(() => Door1Close());

            return vTask;
        }

        private Task<int> Call_Door2Open()
        {
            var vTask = Task.Run(() => Door2Open());

            return vTask;
        }


        private Task<int> Call_Door2Close()
        {
            var vTask = Task.Run(() => Door2Close());

            return vTask;
        }

        private Task<int> Call_RobotArmExtend()
        {
            var vTask = Task.Run(() => RobotArmExtend());

            return vTask;
        }


        private Task<int> Call_RobotArmRetract()
        {
            var vTask = Task.Run(() => RobotArmRetract());

            return vTask;
        }

        private Task<int> Call_RobotRotate()
        {
            var vTask = Task.Run(() => RobotRotate());

            return vTask;
        }
        #endregion



        private int Door1Open()
        {
            eLogSender("Auto",enLogLevel.Info, "Door1 Open Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                //_iDoor1Move = -5;
                fDoor1Draw(-5);
            }

            eLogSender("Auto", enLogLevel.Info, "Door1 Open Complete");

            return 0;
        }


        private int Door1Close()
        {
            eLogSender("Auto", enLogLevel.Info, "Door1 Close Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                //_iDoor1Move = 5;
                fDoor1Draw(5);
            }

            eLogSender("Auto", enLogLevel.Info, "Door1 Close Complete");

            return 0;
        }

        /*
        // 1번 문 Open
        private async Task<int> Door1OpenAsync()
        {
            var vTask = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(_iSpeed);
                    //_iDoor1Move = -5;
                    fDoor1Draw(-5);
                }
            });

            await vTask;

            return 0;
        }
       

        // 1번 문 Close
        private async Task<int> Door1CloseAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(_iSpeed);
                //_iDoor1Move = 5;
                fDoor2Draw(5);
            }

            return 0;
        }
        */

        // 2번 문 Open
        private int Door2Open()
        {
            eLogSender("Auto", enLogLevel.Info, "Door2 Open Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                fDoor2Draw(-5);
            }

            eLogSender("Auto", enLogLevel.Info, "Door2 Open Complete");

            return 0;
        }


        // 2번 문 Close
        private int Door2Close()
        {
            eLogSender("Auto", enLogLevel.Info, "Door2 Close Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                fDoor2Draw(5);
            }

            eLogSender("Auto", enLogLevel.Info, "Door2 Close Complete");

            return 0;
        }


        // Robot Arm Extend (Robot의 팔을 뻗는다)
        private int RobotArmExtend()
        {
            eLogSender("Auto", enLogLevel.Info, "Robot Arm Extend Start");

            // Robot Arm Extend
            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(_iSpeed);
                fRobotDraw(_iRobot_Rotate, -5, _bObjectExist);
            }

            eLogSender("Auto", enLogLevel.Info, "Robot Arm Extend Complete");

            return 0;
        }


        // Robot Arm Retract (Robot의 팔을 접는다)
        private int RobotArmRetract()
        {
            eLogSender("Auto", enLogLevel.Info, "Robot Arm Retract Start");

            // Robot Arm Retract
            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(_iSpeed);
                fRobotDraw(_iRobot_Rotate, 5, _bObjectExist);
            }

            eLogSender("Auto", enLogLevel.Info, "Robot Arm Retract Complete");

            return 0;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            initDraw();
        }

        private void btnSimulationAsync_Click(object sender, EventArgs e)
        {
            Start_Move_Async();
        }



        // Robot Rotate (Robot을 회전 시킴)
        private int RobotRotate()
        {
            eLogSender("Auto", enLogLevel.Info, "Robot Rotate Start");

            for (int i = 0; i < 12; i++)
            {
                Thread.Sleep(_iSpeed);
                _iRobot_Rotate = _iRobot_Rotate + 15;

                fRobotDraw(_iRobot_Rotate, 0, _bObjectExist);
            }

            // 회전을 완료 한 뒤 회전각이 360을 넘어 가면 360 만큼 빼줌
            if (_iRobot_Rotate > 360) _iRobot_Rotate -= 360;

            eLogSender("Auto", enLogLevel.Info, "Robot Rotate Complete");

            return 0;
        }









    }
}
