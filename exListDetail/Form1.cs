using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exListDetail
{
    public partial class Form1 : Form
    {

        List<object> oList = new List<object>();   // Main List 전역으로 선언

        // 진입점
        public Form1()
        {
            InitializeComponent();
        }


        // Button 추가 Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAdd();
        }

        // tboxData에 KeyDown 시 추가 Event
        private void tboxData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataAdd();
            }
        }

        // Button 삭제 Event
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (numPosition.Value == -1)
            {
                oList.Remove(tboxData.Text);   // List 내의 해당 내용 삭제
            }
            else
            {
                oList.RemoveAt((int)numPosition.Value);    // List 내의 해당 Index 삭제
            }

            lboxList.DataSource = oList.ToList<object>();
            LboxNoCreate();
            oList_DataDetail();
        }

        // Button 변경 Event
        private void btnChange_Click(object sender, EventArgs e)
        {
            List<object> ListChange = new List<object>();

            ListChange = oList.ConvertAll<object>(s => s.ToString().Replace(tboxChangeOld.Text, tboxChangeNew.Text));   // List의 값을 변경 해서 새로운 List를 만듬

            lboxChangeList.DataSource = ListChange.ToList();

            oChangeList_DataDetail(ListChange);
        }

        // ListBoxNo에 줄번호를 넣기 위한 함수
        private void LboxNoCreate()
        {
            List<int> iList = (Enumerable.Repeat(0, oList.Count)).ToList<int>();   // List를 선언 하면서 초기화 (여기에서는 그렇게 필요한 부분은 아님;;)

            for (int i = 0; i < iList.Count; i++)
            {
                iList[i] = i + 1;
            }

            lboxNo.DataSource = iList.ToList();
        }


        private void oList_DataDetail()
        {
            tboxList.Text = null;

            int iListCount = oList.Count;    // List 내의 항목 크기
            int ilistCapacity = oList.Capacity;    // List의 메모리 할당 크기
            string strListData = string.Join(", ", oList);    // List의 값을 구분자를 포함한 문자로 변경

            /****** 문자열 보간 ******/

            //StringBuilder sb = new StringBuilder();             // StringBuilder
            //sb.Append("icount : " + iListCount + "\r\n");       

            //string steDe = string.Format("icount : {0}", iListCount);     // String.Format

            // $@""
            string strListDetail = $@"
    Capacity : {ilistCapacity}

    Count : {iListCount}

    Data : {strListData}

    ";

            tboxList.Text = strListDetail;

        }



        private void DataAdd()
        {
            if (numPosition.Value == -1)
            {
                oList.Add(tboxData.Text);    // List 끝에 값을 추가 
            }
            else
            {
                oList.Insert((int)numPosition.Value, tboxData.Text);    // List의 해당 Index 부분에 값을 추가
            }

            lboxList.DataSource = oList.ToList<object>();
            LboxNoCreate();
            oList_DataDetail();

            tboxData.Text = "";
        }



        private void oChangeList_DataDetail(List<object> oChangeList)
        {
            tboxChangeList.Text = null;

            int iListCount = oChangeList.Count;
            int ilistCapacity = oChangeList.Capacity;
            string strListData = string.Join(", ", oChangeList);

            //List<object> oTEST = oChangeList.GetRange(3, 2);      // List에서 해당 위치에서 지정 범위의 값을 추출
            //oChangeList.Sort();          // List 정렬

            string strListDetail = $@"
    Capacity : {ilistCapacity}

    Count : {iListCount}

    Data : {strListData}

    ";

            tboxChangeList.Text = strListDetail;

        }


    }
}
