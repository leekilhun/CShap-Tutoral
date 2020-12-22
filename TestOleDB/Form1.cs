

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOleDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void DBConn(string strDBPath)
        {
            string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={strDBPath}";
            OleDbConnection _conn = new OleDbConnection(connStr);
        }

    }
}
