using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exQueueDataStruc
{
    /// <summary>
    /// Queue와 Stack에 Data를 입,출력 하면서 자료 구조와 Data의 이동을 확인
    /// </summary>
    public partial class Form1 : Form
    {
        Queue<int> _Queue = new Queue<int>(6);  // Queue를 선언 및 초기화
        Stack<int> _Stack = new Stack<int>(6);  // Stack을 선언 및 초기화

        /// <summary>
        /// 진입점
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 입력을 Click 했을 경우 Queue와 Stack에 같은 Data를 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataIn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iData = rd.Next(1, 101);

            //Queue에 Data를 입력
            if (_Queue.Count < 6)
            {
                _Queue.Enqueue(iData);
                fQueueDataDisplay();
            }

            //Stack에 Data를 입력
            if (_Stack.Count < 6)
            {
                _Stack.Push(iData);
                fStackDataDisplay();
            }
        }

        /// <summary>
        /// 출력을 Click 했을 경우 Queue와 Stack에서 Data를 출력 하면서 자료의 이동을 확인
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataOut_Click(object sender, EventArgs e)
        {
            fDataOut();
        }

        private void fDataOut()
        {
            //Queue에 Data를 입력
            if (_Queue.Count > 0)
            {
                _Queue.Dequeue();
                fQueueDataDisplay();
            }

            //Stack에 Data를 입력
            if (_Stack.Count > 0)
            {
                _Stack.Pop();
                fStackDataDisplay();
            }
        }

        /// <summary>
        /// Queue의 자료 구조를 화면에 보여줌
        /// </summary>
        private void fQueueDataDisplay()
        {
            int[] iArray = _Queue.ToArray();

            Array.Resize(ref iArray, 6);

            lblQueue1.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            lblQueue2.Text = (iArray[1] == 0) ? "" : iArray[1].ToString();
            lblQueue3.Text = (iArray[2] == 0) ? "" : iArray[2].ToString();
            lblQueue4.Text = (iArray[3] == 0) ? "" : iArray[3].ToString();
            lblQueue5.Text = (iArray[4] == 0) ? "" : iArray[4].ToString();
            lblQueue6.Text = (iArray[5] == 0) ? "" : iArray[5].ToString();
        }

        /// <summary>
        /// Stack의 자료 구조를 화면에 보여줌
        /// </summary>
        private void fStackDataDisplay()
        {
            int[] iArray = _Stack.ToArray();

            Array.Resize(ref iArray, 6);

            lblStack1.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            lblStack2.Text = (iArray[1] == 0) ? "" : iArray[1].ToString();
            lblStack3.Text = (iArray[2] == 0) ? "" : iArray[2].ToString();
            lblStack4.Text = (iArray[3] == 0) ? "" : iArray[3].ToString();
            lblStack5.Text = (iArray[4] == 0) ? "" : iArray[4].ToString();
            lblStack6.Text = (iArray[5] == 0) ? "" : iArray[5].ToString();
        }




        Timer _oTimer = new Timer();
        bool _bTimer = false;   // Timer 스위치

        private void btnAutoDataOut_Click(object sender, EventArgs e)
        {
            if (_bTimer)
            {
                _oTimer.Stop();

                _bTimer = false;
            }
            else
            {
                _oTimer.Interval = 2000;
                _oTimer.Tick += _oTimer_Tick;
                _oTimer.Start();

                _bTimer = true;
            }
        }

        private void _oTimer_Tick(object sender, EventArgs e)
        {
            fDataOut();
        }
    }
}
