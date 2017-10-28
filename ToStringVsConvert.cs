using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleApp1
{


    public class Customer
    {
        public string fname { set; get; }
        public string lname { set; get; }

       
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            string str=c1.ToString();//cannot handle null, nullrefernceException, if c1=null
            string str1 = Convert.ToString(c1);//this will convert null c1 to empty string

            Console.WriteLine(str);

        }
    }
}
