using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exRecursionFunc
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Control에 Type에 대한 Enum
        /// </summary>
        enum enControlType
        {
            Unknown,
            Label,
            Textbox,
            Button,
        }

        /// <summary>
        /// 진입점
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 실행 Button Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExe_Click(object sender, EventArgs e)
        {
            // Control Level, Control Type, Control Text
            int iLevel = (int)numLevel.Value;

            enControlType eControlType = enControlType.Unknown;
            if (rdoLabel.Checked) eControlType = enControlType.Label;
            else if (rdoTextBox.Checked) eControlType = enControlType.Textbox;
            else if (rdoButton.Checked) eControlType = enControlType.Button;

            string strChangText = tboxChangeText.Text;

            // 위의 조건에 대한 Control을 찾기 위한 함수 호출 
            ControlSearch(gboxCheckList, iLevel, eControlType, strChangText);
        }


        /// <summary>
        /// Control 검색을 위한 함수
        /// </summary>
        /// <param name="CheckList"></param>
        /// <param name="iLevel"></param>
        /// <param name="eType"></param>
        /// <param name="strChangeText"></param>
        private void ControlSearch(GroupBox CheckList, int iLevel, enControlType eType, string strChangeText)
        {
            // 지정한 Group Box 내에 있는 Control을 하나 씩 가져와서 체크 하기 위함 foreach
            foreach (var item in CheckList.Controls)
            {
                // 검색 하려고 하는 Control이 있는 GroupBox의 이름이 "Level + 'Level 번호'" 가 맞을 경우 내부에 있는 Control의 Type을 찾아서 맞을 경우 Text를 변경 함
                if (CheckList.Text.Equals("Level " + iLevel))
                {
                    switch (eType)
                    {
                        case enControlType.Label:
                            if (item is Label)
                            {
                                ((Label)item).Text = strChangeText;
                                lboxResult.Items.Add(string.Format("현재 GroupBox : {0}, Label Text : {1} 로 변경", CheckList.Text, strChangeText));
                            }
                            break;
                        case enControlType.Textbox:
                            if (item is TextBox)
                            {
                                ((TextBox)item).Text = strChangeText;
                                lboxResult.Items.Add(string.Format("현재 GroupBox : {0}, Textbox Text : {1} 로 변경", CheckList.Text, strChangeText));
                            }
                            break;
                        case enControlType.Button:
                            if (item is Button)
                            {
                                ((Button)item).Text = strChangeText;
                                lboxResult.Items.Add(string.Format("현재 GroupBox : {0}, Button Text : {1} 로 변경", CheckList.Text, strChangeText));
                            }
                            break;
                    }
                }

                // GroupBox 내에 있는 Control 중에 GroupBox가 또 존재 할 경우 그 GroupBox 안에 있는 Control에 대해서 Search 하기 위해 현재 돌고 있는 함수를 다시 호출 함!!
                if (item is GroupBox)
                {
                    lboxResult.Items.Add(string.Format("현재 GroupBox : {0}, 다음 GroupBox : {1} 로 이동", CheckList.Text, ((GroupBox)item).Text));
                    ControlSearch((GroupBox)item, iLevel, eType, strChangeText);    // 현재 호출된 함수 내에서 동일한 함수를 다시 호출 함!! (재귀 함수)
                }
            }

            // foreach 문을 다 검색하고 나온 GroupBox와 가장 처음 검색 한 GroupBox가 동일 한 경우 함수가 종료되었다고 판단
            if (CheckList == gboxCheckList)
            {
                lboxResult.Items.Add(string.Format("END"));
            }
        }
    }
}
