using System;
using System.Collections;

namespace exArrayList
{
    public class Program
    {
        public static void Main()
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("hi");
            myAL.Add("welcome");
            myAL.Add("to");
            myAL.Add("c#");
            myAL.Add("world");
            Print("1. Data Insert :", myAL);

            Queue myQ = new Queue();
            myQ.Enqueue("QueueData 1");
            myQ.Enqueue("QueueData 2");
            myAL.AddRange(myQ);
            Print("2. QueueData Insert to ArrayList :", myAL);

            myAL.Insert(2, "novel");
            Print("3. Insert to Location 2  :", myAL);

            myAL.Remove("hi");
            Print("4. Remove Hi Data", myAL);

            myAL.RemoveAt(2);
            Print("5. Remove Index 2 Data", myAL);

            myAL.RemoveRange(2,2);
            Print("6. Remove Index from 2  two Datas", myAL);

            myAL.Sort(0, 3, null);
            Print("7. Sort Index from 0  Three Datas", myAL);

            Console.WriteLine("8.  [ myAL.Capacity ] : {0}", myAL.Capacity);
            Console.WriteLine("9.  [ myAL.Count ] : {0}", myAL.Count);

        }

        private static void Print(string v, IEnumerable myList)
        {
            IEnumerator myEnumerator = myList.GetEnumerator();
            Console.Write(v);
            while (myEnumerator.MoveNext())
            {
                Console.Write("{0},", myEnumerator.Current);
                Console.WriteLine();

            }

        }
    }
}
