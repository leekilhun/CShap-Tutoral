using System;
using System.Collections.Generic;
using System.Text;

namespace exQueueDataStruc
{
    class Qdata
    {
        private string _str ;
        private int _no;

        public Qdata()
        {
            Str = "";
        }

        public string Str { get => _str; set => _str = value; }
        public int No { get => _no; set => _no = value; }
    }
}
