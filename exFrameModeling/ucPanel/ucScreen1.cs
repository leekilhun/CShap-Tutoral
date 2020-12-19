using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exFrameModeling.ucPanel
{
    public partial class ucScreen1 : UserControl
    {
        public event delLogSender eLogSender;

        public ucScreen1()
        {
            InitializeComponent();
        }

        private void btnSc1_Click(object sender, EventArgs e)
        {
            eLogSender("Screen1 Button", enLogLevel.Info, "Button Click");
        }
    }
}
