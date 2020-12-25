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

namespace workFrame.form
{
    public partial class formManual : Form
    {

        public event delLogSender eLogSender;

        public formManual()
        {
            InitializeComponent();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnInit":                
                    break;
                case "btnD1Open":
                    break;
                case "btnD1Close":
                    break;
                case "btnD2Open":
                    break;
                case "btnD2Close":
                    break;
                case "btnRobotE":
                    break;
                case "btnRobotR":
                    break;
                case "btnRobotRotate":
                    break;
                case "btnSimulation":
                    break;
                case "btnSimulationAsync":
                    break;
                default:
                    break;
            }
        }





    }
}
