using System;
using System.Text;


namespace exStringBuilder
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime startTime;
            TimeSpan elapsed;

            //
            string str1 = "";
            startTime = DateTime.Now;
            for(int i=0;i<10000; i++)
            {
                str1 += "H";
            }
            elapsed = DateTime.Now - startTime;
            Console.WriteLine("String : {0}", elapsed.Ticks);

            StringBuilder sb = new StringBuilder();
            startTime = DateTime.Now;
            for (int i =0; i <10000; i++)
            {
                sb.Append("H");
            }
            elapsed = DateTime.Now - startTime;

            Console.WriteLine("StringBuilder : {0}", elapsed.Ticks);
        }
    }
}
