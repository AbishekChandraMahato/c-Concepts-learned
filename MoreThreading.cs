using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    //passing data to thread function in a type safe manner!"

    class Number
    {
        private int _target;
        public Number(int x)
        {
            this._target = x;
        }
        public void PrintNums()
        {

            for (int i = 0; i < _target; i++)
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
            int target = Convert.ToInt32(Console.ReadLine());
            Number number = new Number(target);

            Thread t1 = new Thread(new ThreadStart(number.PrintNums));//type safe poibnters

            t1.Start();//passing value to thread function

        }

    }
}
