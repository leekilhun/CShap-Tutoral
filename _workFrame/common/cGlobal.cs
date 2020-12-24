using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workFrame
{
     class CylinderData
     {
        ushort ID;
        ushort NO;
        string Name;
        CylinderData()
        {

        }
        public CylinderData(ushort id, ushort no, string name)
        {
            this.ID = id;
            this.NO = no;
            this.Name = name;
        }


    }

    public struct CylData
    {
        ushort ID;
        ushort NO;
        string Name;
        
        public CylData(ushort id, ushort no, string name)
        {
            this.ID = id;
            this.NO = no;
            this.Name = name;
        }

    }

    class cGlobal
    {

    }

    // Log Level을 지정 할 Enum
    public enum enLogLevel
    {
        Info,
        Warning,
        Error,
    }

    // UserControl에서 Main으로 Log를 전달 하기 위한 Delegate
    public delegate void delLogSender(object oSender, enLogLevel eLevel, string strLog);
    
}
