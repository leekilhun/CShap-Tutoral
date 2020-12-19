using System;
using System.Collections.Generic;
using System.Text;

namespace exAssemblyVer
{
    class CSize
    {
        string _Name = string.Empty;
        public string Name { get => _Name; set => _Name = value; }

        int _Width = 0;
        public int Width { get => _Width; set => _Width = value; }

        int _Height = 0;
        public int Height { get => _Height; set => _Height = value; }
    }
}
