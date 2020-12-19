using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exStringCon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string S1 = tbox1Value1.Text;
            string S2 = tbox1Value2.Text;

            // He is a Teacher

            //string StrValue0 = S1 + " is " + S2;  // 속도 : strValue0 > strValue1 = strValue2

            string strValue1 = String.Format("{0} is {1}", S1, S2);
            lboxStringFormat.Items.Add(strValue1);
            //lboxStringFormat.Items.Add(String.Format("{0} is {1}", S1, S2));

            string strValue2 = $"{S1} is {S2}";
            lboxStringInterpolation.Items.Add(strValue2);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DateTime dt = dtPicker.Value;

            lboxStringFormat.Items.Add(String.Format("오늘은 {0:yyyy-MM-dd} 입니다.", dt));
            lboxStringInterpolation.Items.Add($"오늘은 {dt:yyyy-MM-dd} 입니다.");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int i1 = (int)num1.Value;
            int i2 = (int)num2.Value;

            int iBigCount = (i1 > i2) ? i1 : i2;

            lboxStringFormat.Items.Add(String.Format("{0}, {1} 중 큰 수는 {2} 이다.", i1, i2, iBigCount)); //(i1 > i2) ? i1 : i2));
            lboxStringInterpolation.Items.Add($"{i1}, {i2} 중 큰 수는 {((i1 > i2) ? i1 : i2)} 이다.");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string strValue = "str";

            lboxStringFormat.Items.Add(String.Format("{{{0}}}", strValue));
            lboxStringInterpolation.Items.Add($"{{{strValue}}}");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string strValue = tbox5Value.Text;

            lboxStringFormat.Items.Add(String.Format("대문자 변환 : {0}", strValue.ToUpper()));
            lboxStringInterpolation.Items.Add($"대문자 변환 : {strValue.ToUpper()}");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string strValue1 = "S1) C:\\Users\\사용자\\Desktop\\문자열보간(실습)\\문자열보간 \r\n TEST";

            string strValue2 = @"S2) C:\Users\사용자\Desktop\문자열보간(실습)\문자열보간 
TEST";

            tbox6Value.Text = strValue1 + "\r\n \r\n" + strValue2;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string strR1 = "Test1";
            string strR2 = "Test2";

            /*
            string strQuery = "Select " + 
                              "ROW_1, " +
                              "ROW_2, " +
            */

            string strQuery = $@"Select 
                                    ROW_1,
                                    ROW_2
                                 From
                                    TB_TABLE
                                 Where 
                                    ROW_1 = {strR1}
                                    AND ROW_2 = {strR2}";

            tbox7Value.Text = strQuery;
        }
    }
}
