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
    public partial class ucScreen3 : UserControl
    {
        public event delLogSender eLogSender;

        public ucScreen3()
        {
            InitializeComponent();
        }

        private void btnSc3_Click(object sender, EventArgs e)
        {
            eLogSender("Screen3 Button", enLogLevel.Info, "Button Click");
        }
    }
}
