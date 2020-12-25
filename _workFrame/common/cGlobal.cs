using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workFrame
{
    public enum cylinder
    {
        unknow,
        LeftDoor_UpDown,
        RightDoor_UPDown,
    }
    public class CylinderData
    {
       public cylinder ID;
       public string Name;
       public ushort[] sensor = new ushort[2];
       public double[] settime = new double[2];
           
       CylinderData()
       {

       }
       public CylinderData(cylinder id, string name, ushort sen1, ushort sen2, double tim1, double tim2)
       {
           this.ID = id;
           this.Name = name;
           sensor[0] = sen1;
           sensor[1] = sen2;
           settime[0] = tim1;
           settime[1] = tim2;
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
