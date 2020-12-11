using System;
using System.Collections;

namespace exQueueClass
{
    class Program
    {
        static void Main()
        {
            Queue que = new Queue();
            que.Enqueue("Hi");
            que.Enqueue(5);
            que.Enqueue(500);
            que.Enqueue("Hello");

            Print("1. Queue's List :", que);

            object obj = que.Dequeue();
            Console.WriteLine("2. Dequeue : {0}", obj);
            obj = que.Dequeue();
            Console.WriteLine("3. Dequeue : {0}", obj);

            Print("4. After Dequeue's List:", que);

            obj = que.Peek();
            Console.WriteLine("5. Peek: {0}", obj);
            Print("6. Queue List After Peek :", que);


        }

        private static void Print(string v, IEnumerable myCollection)
        {
            Console.Write(v + "\n\t");
            IEnumerator MyEumerator = myCollection.GetEnumerator();
            while (MyEumerator.MoveNext())
            {
                Console.Write("{0},", MyEumerator.Current);

            }

            Console.WriteLine();
        }
    }
}
