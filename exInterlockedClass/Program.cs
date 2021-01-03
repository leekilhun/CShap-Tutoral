using System;
using System.Threading;

namespace exInterlockedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Top s = new Top();
            Thread t1 = new Thread(new ThreadStart(s.SayHello));
            Thread t2 = new Thread(new ThreadStart(s.SayHello));
            t1.Start();
            t2.Start();
        }
    }

    internal class Top
    {
        private int limit = 0;
        public void SayHello()
        {
            int hash = Thread.CurrentThread.GetHashCode();
            int count = 0;
            while (count <1000000)
            {
                Interlocked.Increment(ref limit); //limit을 사용하는 순간에 동기화가 보장된다.
                //limit++ // limit을 사용하는 순간에 동기화가 보장되지 않는다.
                count++;
            }
            Console.WriteLine(limit);
        }
    }
}
