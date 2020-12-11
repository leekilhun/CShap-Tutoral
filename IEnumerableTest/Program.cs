using System;
using System.Collections;

namespace IEnumerableTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] authors = { "A", "B", "C", "D", "E", "F" };
            IEnumerator e = authors.GetEnumerator();

            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
        }
    }
}
