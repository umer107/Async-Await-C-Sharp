using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threading
{
    class Program
    {

        //Console Application is main thread
        static void Main(string[] args)
        {

            TestAsyncAwaitMethods();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        static void Thread1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread1");
            }
        }
        static void Thread2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread2");
            }
        }
        async static void TestAsyncAwaitMethods()
        {
            await LongRunningProcess();
        }
        public static async Task<int> LongRunningProcess()
        {
            Console.WriteLine("Starting Long Running method...");
            await Task.Delay(5000);
            Console.WriteLine("End Long Running method...");
            return 1;
        }
    }
}
