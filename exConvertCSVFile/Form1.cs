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

namespace exConvertCSVFile
{
    public partial class Form1 : Form
    {
        public struct rowValue
        {
            public string id { get; set; }
            public string idx { get; set; }
            public string addr { get; set; }
            public string name { get; set; }
            public string etc { get; set; }
            public rowValue(string ID, string IDX, string ADDR, string NAME, string ETC)
            {
                id = ID;idx = IDX;addr = ADDR;name = NAME;etc = ETC;
            }

        }
        public Form1()
        {
            InitializeComponent();

            string filepath = "../IO_Data.csv";
            //DataTable res = ConvertCSVtoDataTable2(filepath);

            rowValue RowsData = new rowValue("OUTPUT", "2", "20002", "OUT_2", "none");
            addRecord(RowsData, filepath);

        }

        public static void addRecord(rowValue values,string filepath)
        {
            try
            {
                using(System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath,true))
                {
                    file.WriteLine(values.id + "," + values.idx + "," + values.addr + "," + values.name + "," + values.etc);
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException("This program did an oopsie:", e);
            }
        }

        public static DataTable ConvertCSVtoDataTable2(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
            string[] headers = sr.ReadLine().Split(',');
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }
            while (!sr.EndOfStream)
            {
                string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void ConvertCSVtoDataTable(string filePath)
        {
            LogMessage("(<-o->)");

            // Counts lines in file    
            long lineCount = 0;
            int columnsCount = 0;
            char divider = '|';

            // FIRST LINE - Read first Line for Columns Count    
            string firstLine = File.ReadLines(filePath).First();

            // FIRST LINE - COUNT columns for DataTable using DIVIDER = "|" from First Line    
            foreach (char c in firstLine) if (c == divider) columnsCount++;


            // CREATE DATATABLE    
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("a"); // Colonne 0    
            dt.Columns.Add("b"); // Colonne 0    
            dt.Columns.Add("c"); // Colonne 0    
            dt.Columns.Add("d"); // Colonne 0    
            dt.Columns.Add("e"); // Colonne 0    
            dt.Columns.Add("f"); // Colonne 0    
            dt.Columns.Add("g"); // Colonne 0    
            dt.Columns.Add("h"); // Colonne 0    
            dt.Columns.Add("i"); // Colonne 0    
            dt.Columns.Add("j"); // Colonne 0    
            dt.Columns.Add("k"); // Colonne 0    
            dt.Columns.Add("l"); // Colonne 0    
            dt.Columns.Add("m"); // Colonne 0    
            dt.Columns.Add("n"); // Colonne 0    
            dt.Columns.Add("o"); // Colonne 0    
            dt.Columns.Add("p"); // Colonne 0    
            dt.Columns.Add("q"); // Colonne 0    
            dt.Columns.Add("r"); // Colonne 0    
            dt.Columns.Add("s"); // Colonne 0    
            dt.Columns.Add("t"); // Colonne 0    
            dt.Columns.Add("u"); // Colonne 0    
            dt.Columns.Add("v"); // Colonne 0    
            dt.Columns.Add("w"); // Colonne 0    
            dt.Columns.Add("x"); // Colonne 0    
            dt.Columns.Add("y"); // Colonne 0    
            dt.Columns.Add("z"); // Colonne 0    


            // READ LINE BY LINE    
            using (StreamReader r = new StreamReader(filePath))
            {
                string line;

                // Reads line by line from the file    
                while ((line = r.ReadLine()) != null)
                {

                    while (line.IndexOf(divider) != -1) // -1 is returned if not found    
                    {

                        // START DIVIDING IN BLOCKS FOR DATATABLE    
                        // Get divider position    
                        int endBlock = line.IndexOf(divider);

                        // Get first Block of text    
                        String firstBlock = line.Substring(0, endBlock);
                        LogMessage("Line: " + lineCount + " - Block: " + firstBlock);
                        // Deletes first text block    
                        line = line.Remove(0, firstBlock.Length + 1);

                        // MOVE TO NEXT CELL/BLOCK UNTIL END OF LINE  

                        // REPEAT IN EVERY LINE  

                        lineCount++;
                    }
                }
            }

        }

        private void LogMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertCSVtoDataTable("../IO_Data.csv");
        }
    }
}
