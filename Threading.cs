using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp1
{



    class Number
    {
        public static void PrintNums()
        {
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Number.PrintNums));//type safe poibnters
            //another method

            //Thread t1 = new Thread(delegate () { Number.PrintNums(); });
            //another method using lambda expression:
            //Thread t1 = new Thread(() => Number.PrintNums());
            t1.Start();
            
        }
            
    }
}
