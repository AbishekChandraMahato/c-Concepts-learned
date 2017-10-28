using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;
namespace ConsoleApp3
{//optional parameters using params, method overloading,parameter defaults, use OptionalAttribute
    class Program
    {
        static void Main(string[] args)
        {


            
            AddNums(1, 2, new int[] { 30, 40 });//rest values are in arrays
            AddNums(1, 2);

            

           

        }
        
        


        
        public static void AddNums(int firstNumber, int secondNumber,  [Optional]int[] restOfNumbers)//third parameter is optional
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
        
        
    }
}
