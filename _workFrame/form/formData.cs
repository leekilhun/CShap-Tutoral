using workFrame.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace workFrame.form
{
    public partial class formData : Form
    {

        public event delLogSender eLogSender;

        public formData()
        {
            InitializeComponent();

            getFileData();

            getInputdec();

            getOutputdec();

            getFlagdec();

            timer.Enabled = true;

        }


        private void writeDatafile()
        {
            using (StreamWriter sw = new StreamWriter(
                new FileStream("IO.dat", FileMode.OpenOrCreate)))
            {

            }
        }

        private void getInputdec()
        {
            int i = 0;
            foreach (AddrInput item in Enum.GetValues(typeof(AddrInput)))
            {
                dataInput.Rows.Add(i.ToString(), (int)item, ((AddrInput)item) );
                i++;
            }
        }

        private void getOutputdec()
        {
            int i = 0;
            foreach (AddrOutput item in Enum.GetValues(typeof(AddrOutput)))
            {
                dataOutput.Rows.Add(i.ToString(), (int)item, item.ToString());
                i++;
            }
        }

        private void getFlagdec()
        {
            dataFlag.Rows.Clear();
            int i = 0;
            foreach (flags item in Enum.GetValues(typeof(flags)))
            {
                dataFlag.Rows.Add(i.ToString(), (int)item, MainForm.Flags[(int)item], item.ToString());
                i++;
            }
        }

        private void getFileData()
        {
            using (StreamReader sr = new StreamReader(new FileStream("../IO.txt", FileMode.Open)))
            {
                int nlength = 0;
                while (!sr.EndOfStream)
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

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView grid = sender as DataGridView;

            // Ctrl + C
            if (e.Control && e.KeyCode == Keys.C)
            {
                DataObject CopiedContent = grid.GetClipboardContent();
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

                int StartingRow = grid.CurrentCell.RowIndex;
                int StartingColumn = grid.CurrentCell.ColumnIndex;

                // 엑셀 처럼 제일 상단 왼쪽셀이 기준 셀이 되게한다.
                for (int i = 0; i < grid.SelectedCells.Count; i++)
                {
                    // 현재 선택된 셀이 가장 작은셀인지 판단.
                    if (StartingRow >= grid.SelectedCells[i].RowIndex
                        && StartingColumn >= grid.SelectedCells[i].ColumnIndex)
                    {
                        StartingRow = grid.SelectedCells[i].RowIndex;
                        StartingColumn = grid.SelectedCells[i].ColumnIndex;
                    }
                }

                foreach (var line in Lines)
                {
                    if (StartingRow <= (grid.Rows.Count - 1))
                    {
                        string[] cells = line.Split('\t');
                        int ColumnIndex = StartingColumn;
                        for (int i = 0; i < cells.Length && ColumnIndex <= (grid.Columns.Count - 1); i++)
                        {
                            grid[ColumnIndex++, StartingRow].Value = cells[i];
                        }
                        StartingRow++;
                    }
                }
            }
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnInit":                
                    break;
                case "btnD1Open":
                    break;
                case "btnD1Close":
                    break;
                case "btnD2Open":
                    break;
                case "btnD2Close":
                    break;
                case "btnRobotE":
                    break;
                case "btnRobotR":
                    break;
                case "btnRobotRotate":
                    break;
                case "btnSimulation":
                    break;
                case "btnSimulationAsync":
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainForm.Flags[3])
                MainForm.Flags[3] = false;
            else
                MainForm.Flags[3] = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            getFlagdec();
        }

        private void dataFlag_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        private void dataFlag_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            timer.Enabled = true;
        }

        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (grid == null)
            {
                return;
            }

            grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.PaleGreen;
        }

        private void formData_Load(object sender, EventArgs e)
        {
            dataGrid.CellValueChanged += new DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);
            dataInput.CellValueChanged += new DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);
            dataOutput.CellValueChanged += new DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);
            dataFlag.CellValueChanged += new DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);

            dataGrid.KeyDown += new KeyEventHandler(this.dataGridView_KeyDown);
            dataInput.KeyDown += new KeyEventHandler(this.dataGridView_KeyDown);
            dataOutput.KeyDown += new KeyEventHandler(this.dataGridView_KeyDown);
            dataFlag.KeyDown += new KeyEventHandler(this.dataGridView_KeyDown);
            
            dataFlag.MouseDown += new MouseEventHandler(this.dataFlag_MouseDown);
            dataFlag.CellEndEdit += new DataGridViewCellEventHandler(this.dataFlag_CellEndEdit);

            button1.Click += new EventHandler(this.button1_Click);
            timer.Tick += new EventHandler(this.timer_Tick);

        }
    }
}
