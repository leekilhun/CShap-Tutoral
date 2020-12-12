using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exDataGridView
{
    public partial class Form1 : Form
    {
        static DataGridView dataGrid;
        public Form1()
        {
            InitializeComponent();

            dataGrid = new DataGridView();
            dataGrid = tblGridView;
            getFileData();
        }

        private void getFileData()
        {
            using(StreamReader sr = new StreamReader(new FileStream("../IO.txt",FileMode.Open)))
            {
                int nlength = 0;
                while(!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    str = Regex.Replace(str, @"\s", "");
                    if (str.IndexOf("//").Equals(0) || str.Length.Equals(0))
                        continue;

                    if (str.IndexOf("//") > 0)
                        nlength = str.Length - str.IndexOf("//");
                    else
                        nlength = str.Length;

                    str = str.Substring(0, nlength);

                    string[] arrystr = str.Split(',');

                    if (!arrystr.Length.Equals(4))
                        continue;
                        
                    
                    dataGrid.Rows.Add(arrystr[0]
                        , uint.Parse(arrystr[1])
                        , arrystr[2]
                        , arrystr[3]);
                    

                }
                

            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl + C
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject CopiedContent = tblGridView.GetClipboardContent();
                Clipboard.SetDataObject(CopiedContent);
                e.Handled = true;
            }

            // Ctrl + V
            if (e.Control && e.KeyCode == Keys.V)
            {

                string CopiedContent = Clipboard.GetText();
                string[] Lines = CopiedContent.Split('\n');

                // 엑셀에서 불러올 경우 \n을 제거한다.
                if (CopiedContent != "")
                {
                    string str = CopiedContent.Substring(CopiedContent.Length - 1);
                    if (str == "\n")
                    {
                        CopiedContent = CopiedContent.Substring(0, CopiedContent.Length - 1);
                    }
                }

                int StartingRow = tblGridView.CurrentCell.RowIndex;
                int StartingColumn = tblGridView.CurrentCell.ColumnIndex;

                // 엑셀 처럼 제일 상단 왼쪽셀이 기준 셀이 되게한다.
                for (int i = 0; i < tblGridView.SelectedCells.Count; i++)
                {
                    // 현재 선택된 셀이 가장 작은셀인지 판단.
                    if (StartingRow >= tblGridView.SelectedCells[i].RowIndex
                        && StartingColumn >= tblGridView.SelectedCells[i].ColumnIndex)
                    {
                        StartingRow = tblGridView.SelectedCells[i].RowIndex;
                        StartingColumn = tblGridView.SelectedCells[i].ColumnIndex;
                    }
                }

                foreach (var line in Lines)
                {
                    if (StartingRow <= (tblGridView.Rows.Count - 1))
                    {
                        string[] cells = line.Split('\t');
                        int ColumnIndex = StartingColumn;
                        for (int i = 0; i < cells.Length && ColumnIndex <= (tblGridView.Columns.Count - 1); i++)
                        {
                            tblGridView[ColumnIndex++, StartingRow].Value = cells[i];
                        }
                        StartingRow++;
                    }
                }
            }
           // [출처] [C#]DataGridView 셀 안에서 복사,붙여넣기(feat. Excel)|작성자 깜둥


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
