using System;
using System.IO;


namespace exMemoryStream
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] values = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(byte b in values)
                Console.Write(b +"\t");

            Console.WriteLine();

            //1.
            MemoryStream ms = new MemoryStream(values);
            int temp = 0;
            while((temp = ms.ReadByte()) != -1)
            {
                Console.Write(temp + "\t");

            }
            Console.WriteLine();

            //2.
            byte[] result = ms.ToArray();
            foreach (byte b in result)
                Console.Write(b + "\t");
            Console.WriteLine(); 

                
            

        }
    }
}
