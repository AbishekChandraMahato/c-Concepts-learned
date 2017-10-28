using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{

   
    class Program
    {

        static int total = 0;
        static object _lock = new object();
        static void Main(string[] args)
        {

            Stopwatch st1 = Stopwatch.StartNew();
            //AddOneMillion();
            //AddOneMillion();
            //AddOneMillion();
            //we have inconsistent outpout everytime
            //protecting shared resources is a solution
            Thread t1 = new Thread(Program.AddOneMillion);
            Thread t2 = new Thread(Program.AddOneMillion);
            Thread t3 = new Thread(Program.AddOneMillion);
            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Total= " + total);
            st1.Stop();
            Console.WriteLine(st1.ElapsedTicks);








        }
        public static void AddOneMillion()
        {
            for(int i = 1; i <= 100000; i++)
            {
                Interlocked.Increment(ref total);//or
                //locking
                //lock (_lock)
                //{
                //    total++;
                //}
                //total++;//not thread safe!
            }
        }

    }
}
