using System;
using System.Collections.Generic;
using System.Text;

namespace exConvertCSVFile
{
    public class IOScript
    {
        public string id { get; set; }
        public string idx { get; set; }
        public string addr { get; set; }
        public string name { get; set; }
        public string etc { get; set; }
        public IOScript(string ID, string IDX, string ADDR, string NAME, string ETC)
        {
            id = ID; idx = IDX; addr = ADDR; name = NAME; etc = ETC;
        }
    }
}
