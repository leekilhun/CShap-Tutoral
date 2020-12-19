using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exLinq
{
    public partial class Form1 : Form
    {
        const string sLEVEL = "LEVEL";
        const string sNAME = "NAME";
        const string sATTRIBUTE = "ATTRIBUTE";

        DataTable dt;

        enum EnumName
        {
            슬라임,
            가고일,
            골렘,
            코볼트,
            고블린,
            고스트,
            언데드,
            노움,
            드래곤,
            웜,
            서큐버스,
            데빌,
            만티코어,
            바실리스트,
        }

        enum EnumAttribute
        {
            불,
            물,
            바람,
            번개,
            어둠,
            빛,
            땅,
            나무,
        }

        /// <summary>
        /// 진입점
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTableCreate();  // Data Table 생성
            EnemyCreate();  // 정보 생성
            ComboBoxCreate(); // ComboBox에 Data 입력
        }

        /// <summary>
        /// DataTable 틀을 생성 (※23강 Data Table 생성 참조)
        /// </summary>
        private void DataTableCreate()
        {
            dt = new DataTable("Enemy");

            //DataColumn 생성
            DataColumn colLevel = new DataColumn(sLEVEL, typeof(int));
            DataColumn colName = new DataColumn(sNAME, typeof(string));
            DataColumn colAttribute = new DataColumn(sATTRIBUTE, typeof(string));

            dt.Columns.Add(colLevel);
            dt.Columns.Add(colName);
            dt.Columns.Add(colAttribute);
        }

        /// <summary>
        /// Data Table에 자료를 입력
        /// </summary>
        private void EnemyCreate()
        {
            Random rd = new Random();

            foreach (EnumName oName in Enum.GetValues(typeof(EnumName)))   // ※15강 캡슐화에서 사용
            {
                DataRow dr = dt.NewRow();

                dr[sLEVEL] = rd.Next(1, 11);  // 1 ~ 10 중에서 Random
                dr[sNAME] = oName.ToString();  // 이름을 넣어 줌

                int iEnumLength = Enum.GetValues(typeof(EnumAttribute)).Length;  // Enum 의 개수를 가져옴
                int iAttribute = rd.Next(iEnumLength);
                dr[sATTRIBUTE] = ((EnumAttribute)iAttribute).ToString();

                dt.Rows.Add(dr);
            }

            dgEnemyTable.DataSource = dt;
        }

        /// <summary>
        /// Combox에 EnumAttribute를 입력
        /// </summary>
        private void ComboBoxCreate()
        {
            foreach (EnumAttribute oAttribute in Enum.GetValues(typeof(EnumAttribute)))
            {
                cboxAttribute.Items.Add(oAttribute);
            }
            cboxAttribute.SelectedIndex = 0;
        }

        /// <summary>
        /// Level, Name, 속성 정렬 Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, EventArgs e)
        {
            Button oBtn = sender as Button;

            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;   // DataGridViewe에 있는 Data를 dtCopy에 복사

            IEnumerable<DataRow> vSortTable = null;

            switch (oBtn.Name)
            {
                case "btnLevel":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<int>(sLEVEL) // 정렬 기준
                                 select oRow;
                    break;
                case "btnName":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<string>(sNAME) // 정렬 기준
                                 select oRow;
                    break;
                case "btnAttribute":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<string>(sATTRIBUTE) // 정렬 기준
                                 select oRow;
                    break;
            }

            dtCopy = vSortTable.CopyToDataTable();
            dgEnemyTable.DataSource = dtCopy;
        }


        /// <summary>
        /// Filter Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;   // DataGridViewe에 있는 Data를 dtCopy에 복사

            IEnumerable<DataRow> vSortTable = from oRow in dtCopy.AsEnumerable()
                                              where oRow.Field<string>(sATTRIBUTE) == cboxAttribute.Text &&
                                              (oRow.Field<int>(sLEVEL) >= nLevelMin.Value && oRow.Field<int>(sLEVEL) <= nLevelMax.Value)
                                              select oRow;

            if (vSortTable.Count() > 0)
            {
                dtCopy = vSortTable.CopyToDataTable();
                dgEnemyTable.DataSource = dtCopy;
            }
            else
            {
                MessageBox.Show("검색 조건에 맞는 Data가 없습니다.");
            }

        }


        /// <summary>
        /// Cancel Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgEnemyTable.DataSource = dt;
        }
    }
}
