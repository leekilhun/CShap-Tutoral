using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exException
{
    public partial class Form1 : Form
    {
        Dictionary<string, Color> dColor = new Dictionary<string, Color>();  // 색상정보를 담아 둘 Dictionary
        Color oSelectColor = new Color();   // 현재 선택 된 생상 정보를 가지고 있을 변수

        /// <summary>
        /// 프로그램 진입점
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// ColorDialog Event를 불러올 Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog();  // ColorDialog를 불러서 선택한 뒤 결과 값까지 받아 옴

            if (dRet == DialogResult.OK)   //결과 값이 정상일 때 선택 된 Color를 Panel에 뿌려줌
            {
                pColor.BackColor = cDialogColor.Color;
            }

            lblColorinfo.Text = pColor.BackColor.ToString();
        }


        /// <summary>
        /// trackbar의 값이 변할때 불러오는 Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbarAlpha_Scroll(object sender, EventArgs e)
        {
            pColor.BackColor = Color.FromArgb(tbarAlpha.Value, pColor.BackColor);  // 색상 값에 Alpha 값을 변경해서 다시 저장 함
            lblColorinfo.Text = pColor.BackColor.ToString();
        }


        /// <summary>
        /// 저장 Button을 Click 했을 경우 선택 색상을 사전에 저장 한 뒤 사전에 있는 값을 List에 뿌려 줌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColorSave_Click(object sender, EventArgs e)
        {
            try
            {
                Color oColor = pColor.BackColor;
                dColor.Add(oColor.ToString(), oColor);

                LBoxRefresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 삭제 Button을 Click 했을 경우 List에서 선택된 값과 같은 key를 가진 사전에 있는 값을 삭제 한뒤 List를 다시 뿌려 줌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // 사전에 있는 색상을 삭제하고 

                if (lboxColor.SelectedItem != null && dColor.ContainsKey(lboxColor.SelectedItem.ToString()))
                {
                    dColor.Remove(lboxColor.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("삭제할 Item이 없거나 사전에 키가 없습니다.");
                }
                
                // List를 다시 화면에 뿌려준다
                LBoxRefresh();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        /// <summary>
        /// 사전에 있는 값으로 ListBox를 새로 그려 줌
        /// </summary>
        private void LBoxRefresh()
        {
            try
            {
                lboxColor.Items.Clear();

                foreach (string okey in dColor.Keys)
                {
                    lboxColor.Items.Add(okey);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        /// <summary>
        /// ListBox의 선택 값이 변경 되면 변경 된 선택 값의 색상 정보를 oSelectColor 변수에 저장 함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            oSelectColor = dColor[lboxColor.SelectedItem.ToString()];
        }
        
        /// <summary>
        /// 그림 판에 있는 Panel 중 선택 된 Panel에 대해서 저장한 색상 정보를 기준으로 다시 그려 줌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_Click(object sender, MouseEventArgs e)
        {
            try
            {
                //TextBox oTbox = sender as TextBox;
                //TextBox oTbox = (TextBox)sender;

                if (sender is Panel)
                {
                    Panel oPanel = sender as Panel;
                    oPanel.BackColor = oSelectColor;
                }
                else if(sender is Button)
                {
                     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
