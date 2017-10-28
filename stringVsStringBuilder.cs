using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

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
            string userString = "C#";
            userString += " Videos";

            //can be changed number of times.....
            //creates object everytime, no pointing to previous value, still remains in memory
            Console.WriteLine(userString);


            StringBuilder s1 = new StringBuilder("C#");
            s1.Append(" Videos");
            s1.Append(" are awesome");

            Console.WriteLine(s1.ToString());

            //better performance, also for heavy string operations
            string x = string.Empty;
            string y = null;
            string z = "";

        }
    }
}
