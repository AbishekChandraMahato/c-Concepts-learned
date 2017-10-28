using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp1
{

   
    class Program
    {

        public static void ThreadFunc1()
        {
            Console.WriteLine("Thread1 func started");
            Thread.Sleep(5000);
            Console.WriteLine("thread 1 func , about to return!");
        }
        public static void ThreadFunc2()
        {
            Console.WriteLine("Thread2 func started");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("main started");
            Thread t1 = new Thread(Program.ThreadFunc1);
            t1.Start();

            Thread t2 = new Thread(Program.ThreadFunc2);
            t2.Start();

            t1.Join(10000);//by doing this the main method waits , so that this thread is returned
            //main thread will continue executing after 1 sec, no matter what!
            if (t1.Join(1000))
            {
                Console.WriteLine("Thread func completed in a sec");
            }
            else
            {
                Console.WriteLine("Thread func not completed inn a sec");
            }
            Console.WriteLine("Thread one completed!");
            t2.Join();
            Console.WriteLine("Thread two completed!");
            if (t1.IsAlive)//checks whether the thread func is still in process or not
            {
                Console.WriteLine("thread 1 still processing");
            }
            else
            {
                Console.WriteLine("thread 1 completed");
            }
            Console.WriteLine("Main completed");


           

        }

    }
}
