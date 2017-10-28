using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    //Retreiving  data from thread function using call back function
    public delegate void SumOfNumbersCallBack(int sumOfNumbers);//call back delegate
    class Number
    {
        int _target;
        SumOfNumbersCallBack _callBackMethod;
        public Number(int x,SumOfNumbersCallBack callBackMethod)
        {
            this._target = x;
            this._callBackMethod = callBackMethod;
        }
        public void PrintSums()
        {
            int sum = 0;
            for (int i = 0; i < _target; i++)
            {
                sum += i;
            }
            if (_callBackMethod != null)
            {
                _callBackMethod(sum);
            }
           
        }
    }
    class Program
    {

        public static void PrintSum(int sum)//call back function
        {
            Console.WriteLine("Sum: {0}",sum);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("please enter a num: ");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallBack callback = new SumOfNumbersCallBack(PrintSum);//dlegate pointing to call back func



            Number number = new Number(target,callback);

            Thread t1 = new Thread(new ThreadStart(number.PrintSums));//type safe poibnters

            t1.Start();//passing value to thread function

        }

    }
}
