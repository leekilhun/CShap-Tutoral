using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exUserControl
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Program 진입점
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Program을 Load 했을 경우에 발생 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // pMain Control 안에서 생성한 UserControl을 찾아서 형변환 한 뒤 Event를 생성 함
            foreach (var oControl in pMain.Controls)
            {
                if (oControl is UCInfo)
                {
                    UCInfo oInfo = oControl as UCInfo;

                    oInfo.eventdelSender += OInfo_eventdelSender;
                }
            }
        }


        /// <summary>
        /// UserControl Delegate Event 
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="strText"></param>
        /// <returns></returns>
        private int OInfo_eventdelSender(object Sender, string strText)
        {
            UCInfo oInfo = Sender as UCInfo;

            lboxList.Items.Add(string.Format("{0}) {1}", oInfo.UserNo, strText));

            return 0;
        }
    }
}
