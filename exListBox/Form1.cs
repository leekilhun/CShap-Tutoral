using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum eDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thusday,
            Friday,
            Saturday,
            Sunday,

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWeeks.Items.Add(eDay.Monday.ToString());  //
            lbWeeks.Items.Add(eDay.Tuesday); // skip ToString
            lbWeeks.Items.Add(eDay.Wednesday);
            lbWeeks.Items.Add(eDay.Thusday);
            lbWeeks.Items.Add(eDay.Friday);
            lbWeeks.Items.Add(eDay.Saturday);
            lbWeeks.Items.Add(eDay.Friday);
            lbWeeks.Items.Add(eDay.Sunday);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string strResult = TextLoad(lbWeeks.SelectedItem.ToString());
            tboxResult.Text = strResult;

        }

        /// <summary>
        /// make text from listbox
        /// </summary>
        /// <param name="day">week name</param>
        /// <returns></returns>
        private string TextLoad(string day)
        {
            string strText = string.Format("{0} is Good", day);
            return strText;
        }
    }

  

}
