using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace ConsoleApp3
{//optional parameters using params, method overloading
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(1, 2);
            AddNumbers(1, 2, 3);//after second parameter, all are optional
            AddNumbers(1, 2, 3,2,36,9,100);



        }
        //params arrays
        public static void AddNumbers(int firstNumber,int secondNumber,params object[] restOfNumbers)//params must be the last parameter
        {
            int res = firstNumber + secondNumber;
            if (restOfNumbers!=null)
            {
                foreach(int i in restOfNumbers)
                {
                    res += i;
                }
            }
            Console.WriteLine("Sum: "+res);
        }

        


        //method overloading
        public static void AddNums(int firstNumber, int secondNumber,  int[] restOfNumbers)
        {
            int res = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    res += i;
                }
            }
            Console.WriteLine("Sum: " + res);
        }
    }
}
