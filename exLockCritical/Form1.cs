using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exLockCritical
{
    public partial class Form1 : Form
    {
        Thread _T1;   // Thread
        Thread _T2;   // Thread

        object RoomLock = new object();   // Lock에 사용 할 object
        object RoomLock2 = new object();   // Lock에 사용 할 object (Test 용)

        int _iRoom1Count = 1;
        int _iRoom2Count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnRoom1 Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoom1_Click(object sender, EventArgs e)
        {
            lboxRoom1.Items.Add(string.Format("Room 1 : {0} 예약", _iRoom1Count));   // ListBox의 Item에 값을 넣어 줌 (Thread 내부에서 UI에 접근하지 않음으로 바로 등록 가능)

            _T1 = new Thread(new ParameterizedThreadStart(Run));   // Thread 함수에 Parameter를 전달 하기 위해 사용 (함수는 object로 선언 해야 함)
            _T1.Start(_iRoom1Count);     // Thread 시작 시 Parameter 전달

            _iRoom1Count++;
        }

        /// <summary>
        /// Thread에 사용 할 함수 (인자값은 object type으로 정의해야 함)
        /// </summary>
        /// <param name="obj"></param>
        private void Run(object obj)
        {
            lock (RoomLock)   // Lock (Thread 임계지점 등록)
            {
                // 참고 : Thread 내에서 UI Update가 필요 할 경우 Update 시점에만 UI 쪽으로 접근 권한을 넘겨 줘서 사용 하는것이 좋음
                //        아닐 경우 Thread가 수행 중일 경우 UI가 Thread를 점유 하는 경우가 밥생 (프로그램이 버벅댐)

                invokeFunction(lblLockStatus, String.Format("Room 1 : Player {0} 사용 중", obj));   // Thread 내 UI Update를 위한 별도 함수 지정 (자주 사용 되어 별도 지정)

                for (int i = 1; i <= 3; i++)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(delegate ()
                        {
                            lboxResult.Items.Add(String.Format("Room 1 : Player {0} 진행 중 . . . {1}", obj, i));
                            Refresh();
                        }));
                    }

                    Thread.Sleep(1000);    // Program 강제 Delay를 주기 위해 Thread를 1초간 멈춰 놓음
                }

                invokeFunction(lblLockStatus, String.Format("Room 1 : Player {0} 사용 완료", obj));
                Thread.Sleep(1000);
            }
        }


        private void btnRoom2_Click(object sender, EventArgs e)
        {
            lboxRoom2.Items.Add(string.Format("Room 2 : {0} 예약", _iRoom2Count));

            _T2 = new Thread(new ParameterizedThreadStart(Run2));
            _T2.Start(_iRoom2Count);

            _iRoom2Count++;
        }


        private void Run2(object obj)
        {
            //lock (RoomLock2)  // 개별 Lock을 사용 했을 떄 동작 확인 용 (Test 용)
            lock (RoomLock)
            {
                invokeFunction(lblLockStatus, String.Format("Room 2 : Player {0} 사용 중", obj));

                for (int i = 1; i <= 3; i++)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(delegate ()
                        {
                            lboxResult.Items.Add(String.Format("Room 2 : Player {0} 진행 중 . . . {1}", obj, i));
                            Refresh();
                        }));
                    }

                    Thread.Sleep(1000);
                }

                invokeFunction(lblLockStatus, String.Format("Room 2 : Player {0} 사용 완료", obj));
                Thread.Sleep(1000);
            }
        }


        /// <summary>
        /// Label에 대해서 다른 Thread에서 수행 시 UI Update를 시켜 주기 위한 함수
        /// </summary>
        /// <param name="objlabel"></param>
        /// <param name="str"></param>
        private void invokeFunction(Label objlabel, string str)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate ()
                {
                    objlabel.Text = str;
                }));
            }
        }
    }
}
