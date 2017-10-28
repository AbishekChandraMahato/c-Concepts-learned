using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace ConsoleApp3
{//optional parameters using params, method overloading,parameter defaults
    class Program
    {
        static void Main(string[] args)
        {


            AddNums(10,20);// its allowed as default value is specified
            AddNums(1, 2, new int[] { 30, 40 });//rest values are in arrays

            test(1);
            test(1, 2, 3);
            test(1, c: 4);

        }
        
        


        
        public static void AddNums(int firstNumber, int secondNumber,  int[] restOfNumbers=null)//default value of null
            //the optional param must come at the end, after all required params
        {
            int res = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    res += i;
                }
            }
            Console.WriteLine("Sum: " + res.ToString());
        }
        public static void test(int a,int b=10,int c = 12)//specifying default values
        {
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= " + b);
            Console.WriteLine("c= " + c);
        }
        
    }
}
