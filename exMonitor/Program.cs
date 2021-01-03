/**
 * Monitor 클래스를 이용한 동기화를 테스트하는 예제
 **/
using System;
using System.Threading;

namespace exMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Top t1 = new Top();
            Top t2 = new Top();
            ThreadStart ts1 = new ThreadStart(t1.SayHello);
            ThreadStart ts2 = new ThreadStart(t2.SayHello);

            Thread thread1 = new Thread(ts1);
            Thread thread2 = new Thread(ts2);

            thread1.Start();
            thread2.Start();

            Console.Write("\nThread" + Thread.CurrentThread.GetHashCode() + "메인 종료 \n");
        }

    }

    internal class Top
    {
        private static object obj = new object();
        public void SayHello()
        {
            int hash = Thread.CurrentThread.GetHashCode();
            int count = 0;
            Monitor.Enter(Top.obj); //동기화 진입
            try
            {
                while (count <10)
                {
                    Console.WriteLine("Thread" + hash + ":" + count++);
                    Thread.Sleep(10);
                    if (count == 5)
                    {
                        throw (new Exception());

                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                Monitor.Exit(Top.obj);// 동기화 종료
            }
        }
    }
}
