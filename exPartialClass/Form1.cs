using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exPartialClass
{
    public partial class Form1 : Form
    {
        cData _Data = new cData();  // cData라는 Glass를 사용 할 수 있도록 선업하고 초기화 하였습니다. (이번 강의 핵심 Class)

        /// <summary>
        /// 프로그램의 진입점 입니다.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Form1을 Load 하는 시점에 ComboBox에 Data를 넣어 줍니다. (EnumClass.cs에 Enum 관련 된 내용들을 정리 하고 가지고와서 사용 하였습니다.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));  // Enum에 있는 값들을 배열 형태로 불러옵니다. (Enum을 많이 쓰시면 자주 사용 됩니다.)

            foreach (EnumItem oitem in ei)  //foreach 문으로 Enum 형태의 배열에 있는 값을 하나씩 가져와서 ComboBox에 넣어 줍니다.
            {
                cboxItem.Items.Add(oitem.ToString());
            }

            foreach (EnumRate oitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))   // 위와 같음
            {
                cboxRate.Items.Add(oitem.ToString());
            }
        }

        /// <summary>
        /// Button "담기"를 Click 하였을 경우 cData Class에 Form에 Setting 된 값을 넣어주고 계산을 한뒤 값을 ListBox에 보여 줍니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Data.fDataResult();  // cData에 있는 변수 값들을 초기화 시킴

            _Data.StrItem = cboxItem.Text;
            _Data.IRate = (int)Enum.Parse(typeof(EnumRate), cboxRate.Text);  // 문자 형태로 가지고 있는 Enum 값을 int 형태로 변환 시킴 (Enum을 많이 쓰시면 자주 사용 됩니다.)
            _Data.ICount = (int)numCout.Value;

            if (!String.IsNullOrEmpty(_Data.StrErrorName))   // Error Data가 있을 경우 tboxErrorMsg에 Error 내용을 보여주고 종료
            {
                tboxErrorMsg.Text = _Data.StrErrorName;
                return;
            }

            //Error가 없을 경우 아래 할인 가격을 계산하는 Logic을 수행 후 ListBox에 값을 뿌려줌.

            double dPrice = _Data.fItemPrice();
            lboxItem.Items.Add(_Data.fResult(dPrice));

            _Data.DTotalPrice = dPrice;
            tboxResult.Text = _Data.DTotalPrice.ToString() + "원";
        }
    }
}
