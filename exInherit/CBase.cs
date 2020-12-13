using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace exInherit
{
    class CBase
    {
        public string strName;
        protected Pen _Pen;
        public CBase()
        {
            _Pen = new Pen(Color.Aqua);
        }
    }
}
