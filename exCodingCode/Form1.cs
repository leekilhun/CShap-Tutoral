using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exCodingCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // 1.기능 위주로 구현 

            //string R1 = tboxBefore.Text.Replace("개똥", "사탕");
            //tboxAfter.Text = R1;

            //string R2 = tboxBefore.Text.Replace("닭", "과자");
            //tboxAfter.Text = R2;

            //string R3 = tboxBefore.Text.Replace("꿩", "아이스크림");
            //tboxAfter.Text = R3;

            //string R4 = tboxBefore.Text.Replace("생선", "우유");
            //tboxAfter.Text = R4;

            //string R5 = tboxBefore.Text.Replace("알", "돈");
            //tboxAfter.Text = R5;



            // 2. 결과를 보고 수정 필요 내용을 확인 후 수정

            //StringBuilder sb = new StringBuilder();
            //string[] strList = tboxBefore.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            //string R1 = strList[0].Replace("개똥", "사탕");
            //sb.Append(R1 + "\r\n");

            //string R2 = strList[1].Replace("닭", "과자");
            //sb.Append(R2 + "\r\n");

            //string R3 = strList[2].Replace("꿩", "아이스크림");
            //sb.Append(R3 + "\r\n");

            //string R4 = strList[3].Replace("생선", "우유");
            //sb.Append(R4 + "\r\n");

            //string R5 = strList[4].Replace("알", "돈");
            //sb.Append(R5 + "\r\n");

            //tboxAfter.Text = sb.ToString();



            // 3. 개선할 점 고민 후 프로그램 개선

            //StringBuilder sb = new StringBuilder();
            //string[] strList = tboxBefore.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            //string R1 = strList[0].Replace(dgChangedate["cBefore", 0].Value.ToString(), dgChangedate["cAfter", 0].Value.ToString());
            //sb.Append(R1 + "\r\n");

            //string R2 = strList[1].Replace(dgChangedate["cBefore", 1].Value.ToString(), dgChangedate["cAfter", 1].Value.ToString());
            //sb.Append(R2 + "\r\n");

            //string R3 = strList[2].Replace(dgChangedate["cBefore", 2].Value.ToString(), dgChangedate["cAfter", 2].Value.ToString());
            //sb.Append(R3 + "\r\n");

            //string R4 = strList[3].Replace(dgChangedate["cBefore", 3].Value.ToString(), dgChangedate["cAfter", 3].Value.ToString());
            //sb.Append(R4 + "\r\n");

            //string R5 = strList[4].Replace(dgChangedate["cBefore", 4].Value.ToString(), dgChangedate["cAfter", 4].Value.ToString());
            //sb.Append(R5 + "\r\n");

            //tboxAfter.Text = sb.ToString();




            //4. 프로그램 코드 정리

            StringBuilder sb = new StringBuilder();
            string[] strList = tboxBefore.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int iListRow = 0; iListRow < strList.Length; iListRow++)
            {
                sb.Append(fReplaceResult(strList[iListRow], iListRow));
            }

            tboxAfter.Text = sb.ToString();
        }


        /// <summary>
        /// DataGridView에서 변환 할 값을 찾은 후 입력값에서 값을 변환 후 변환 값을 반환 
        /// </summary>
        /// <param name="strBeforeText"></param>
        /// <param name="idgRow"></param>
        /// <returns></returns>
        private string fReplaceResult(string strBeforeText, int idgRow)
        {
            string strAfterText = string.Empty;

            strAfterText = strBeforeText.Replace(dgChangedate["cBefore", idgRow].Value.ToString(), dgChangedate["cAfter", idgRow].Value.ToString());

            strAfterText = strAfterText + "\r\n";

            return strAfterText;
        }

    }
}
