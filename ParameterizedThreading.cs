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
        public static void PrintNums(object target)
        {
            int num = 0;
            int.TryParse(target.ToString(),out num);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("please enter a num: ");
           object target= Convert.ToInt32(Console.ReadLine());
            ParameterizedThreadStart pts1 = new ParameterizedThreadStart(Number.PrintNums);
            Thread t1 = new Thread(pts1);//type safe poibnters
            //another method

            //Thread t1 = new Thread(delegate () { Number.PrintNums(); });
            //another method using lambda expression:
            //Thread t1 = new Thread(() => Number.PrintNums());
            t1.Start(target);//passing value to thread function
            
        }
            
    }
}
