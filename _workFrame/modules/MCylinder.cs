using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workFrame.modules
{
   
    public class MCylinder : CBase
    {
        ushort ID;
        CylinderData CylData;

        public MCylinder(ushort id, CylinderData data)
        {
            ID = id;
            CylData = data;

        }

        

    }
}

