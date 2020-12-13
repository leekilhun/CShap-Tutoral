using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exInherit
{
    public partial class Form1 : Form
    {
        COneCycle _cOC;  // 외발 자전거 Class
        CCycle _cC;   // 자전거 Class
        CCar _cCar;   // 자동차 Class

        /// <summary>
        /// 프로그램의 진입점 입니다.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
            _cC = new CCycle("자전거");
            _cCar = new CCar("자동차");
        }

        /// <summary>
        /// 화면에서 "외발 자전거" Button을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fOneCycleDraw();
        }

        /// <summary>
        /// 화면에서 "자전거" Button을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCycleDraw();
        }

        /// <summary>
        /// 화면에서 "자동차" Button을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCar_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCarDraw();
        }




        /// <summary>
        /// OneCycle 대한 위치 그림을 그려준다
        /// </summary>
        private void fOneCycleDraw()
        {
            lblName.Text = _cOC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cOC.fPenInfo();
            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);
        }

        /// <summary>
        /// Cycle 대한 위치 그림을 그려준다
        /// </summary>
        private void fCycleDraw()
        {
            lblName.Text = _cC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cC.fPenInfo();
            g.DrawRectangle(p, _cC._rtSquare1);
            g.DrawEllipse(p, _cC._rtCircle1);
            g.DrawEllipse(p, _cC._rtCircle2);
        }

        /// <summary>
        /// Car 대한 위치 그림을 그려준다
        /// </summary>
        private void fCarDraw()
        {
            lblName.Text = _cCar.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cCar.fPenInfo();
            g.DrawRectangle(p, _cCar._rtSquare1);
            g.DrawRectangle(p, _cCar._rtSquare2);
            g.DrawEllipse(p, _cCar._rtCircle1);
            g.DrawEllipse(p, _cCar._rtCircle2);
        }

        /// <summary>
        /// 화면에 그려진 그림을 지운다
        /// </summary>
        private void fClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }


        /// <summary>
        /// 화면에서 "왼쪽 화살표" Button을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            fClearPanel();

            switch (lblName.Text)
            {
                case "외발 자전거":
                    _cOC.fMove(-5);
                    fOneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(-5);
                    fCycleDraw();
                    break;
                case "자동차":
                    _cCar.fMove(-5);
                    fCarDraw();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 화면에서 "오른쪽 화살표" Button을 Click 했을 때 Event를 발생 시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e)
        {
            fClearPanel();

            switch (lblName.Text)
            {
                case "외발 자전거":
                    _cOC.fMove(5);
                    fOneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(5);
                    fCycleDraw();
                    break;
                case "자동차":
                    _cCar.fMove(5);
                    fCarDraw();
                    break;
                default:
                    break;
            }

        }

        
    }
}
