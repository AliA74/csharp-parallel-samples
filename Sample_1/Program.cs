using System;
using System.Threading;

namespace Sample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintB);
            thread.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("A");
            }
        }

        static void PrintB()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("B");
            }
        }
    }
}
