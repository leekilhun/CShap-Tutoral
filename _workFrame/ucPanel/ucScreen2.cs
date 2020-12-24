using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workFrame.ucPanel
{
    public partial class ucScreen2 : UserControl
    {
        public event delLogSender eLogSender;

        public ucScreen2()
        {
            InitializeComponent();
        }

        /*
        private void btnReload_Click(object sender, EventArgs e)
        {
            eLogSender("Chart 화면", enLogLevel.Info, $"Reload Button을 Click 하였습니다. (차트를 새로 그립니다.)");
        }
        */

        private void btnSc2_Click(object sender, EventArgs e)
        {
            eLogSender("Screen2 Button", enLogLevel.Info, "Button Click");
        }
    }
}
