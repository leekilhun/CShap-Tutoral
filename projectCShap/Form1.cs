using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectCShap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl + C
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject CopiedContent = dataGridViewTest.GetClipboardContent();
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

                int StartingRow = dataGridViewTest.CurrentCell.RowIndex;
                int StartingColumn = dataGridViewTest.CurrentCell.ColumnIndex;

                // 엑셀 처럼 제일 상단 왼쪽셀이 기준 셀이 되게한다.
                for (int i = 0; i < dataGridViewTest.SelectedCells.Count; i++)
                {
                    // 현재 선택된 셀이 가장 작은셀인지 판단.
                    if (StartingRow >= dataGridViewTest.SelectedCells[i].RowIndex
                        && StartingColumn >= dataGridViewTest.SelectedCells[i].ColumnIndex)
                    {
                        StartingRow = dataGridViewTest.SelectedCells[i].RowIndex;
                        StartingColumn = dataGridViewTest.SelectedCells[i].ColumnIndex;
                    }
                }

                foreach (var line in Lines)
                {
                    if (StartingRow <= (dataGridViewTest.Rows.Count - 1))
                    {
                        string[] cells = line.Split('\t');
                        int ColumnIndex = StartingColumn;
                        for (int i = 0; i < cells.Length && ColumnIndex <= (dataGridViewTest.Columns.Count - 1); i++)
                        {
                            dataGridViewTest[ColumnIndex++, StartingRow].Value = cells[i];
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
