using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exTimer
{
    public partial class Form1 : Form
    {
        private double iTick = 0;  // 한 Tick 당 더할 값
        private double iTotal = 0;  // 전체 값

        private int i1Add = 1;  // 1 * LEVEL 값
        private int i1Level = 1;

        private int i3Add = 3;  // 3 * LEVEL 값
        private int i3Level = 1;

        private int i50Add = 0;   // 50 * LEVEL 값
        private int i50Level = 0;


        /// <summary>
        /// 진입점
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Form이 Loading 될때 발생 하는 Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer oTimer = new System.Windows.Forms.Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 100;
            oTimer.Tick += OTimer_Tick;
            oTimer.Start();
        }


        // 타이머에서 호출 할 Event (Interval 간격 기준)
        private void OTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i3Add + i50Add;
            iTotal = iTotal + iTick;

            lblTickPoint.Text = string.Format("{0} (1:{1}), (3:{2}), (50:{3})", iTick.ToString(), i1Level.ToString(), i3Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();
        }


        /// <summary>
        /// Button을 Click 했을 경우 발생 하는 Event (Form Designer에서 Button 종류를 묶어서 하나의 Event로 받음)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button;  // 받아온 Sender를 Button 형으로 변환 시킴

            // UI 작성 시 지정한 Name을 기준으로 Event가 발생 한 Button을 찾아서 프로그램 동작 수행
            switch (obtn.Name)
            {
                case "btn1Add":
                    if (iTotal > 100)
                    {
                        iTotal = iTotal - 100;

                        i1Level++;
                        i1Add = 1 * i1Level;
                    }
                    break;
                case "btn3Add":
                    if (iTotal > 300)
                    {
                        iTotal = iTotal - 300;

                        i3Level++;
                        i3Add = 3 * i3Level;
                    }
                    break;
                case "btn50Add":
                    if (iTotal > 5000)
                    {
                        iTotal = iTotal - 5000;

                        i50Level++;
                        i50Add = 50 * i50Level;
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
