using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public partial class PartialCustomer//same class name, partial one
    {
        private string _fname;
        private string _lname;

        public string FirstName
        {
            get
            {
                return this._fname;
            }
            set
            {
                this._fname = value;
            }
        }

        public string Lname { get => _lname; set => _lname = value; }
    }
}



partiality+


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public partial class PartialCustomer//same class name, partial two
    {
        public string getFullName()
        {
            return _fname + " ," + _lname;
        }

    }
}




main

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.FirstName = "Abishek";
            c1.Lname = "Mahato";
            Console.WriteLine(c1.getFullName());

            PartialCustomer c2 = new PartialCustomer();//instantiation and invoking as if one class
            //this class is contained partially contained in two different class
            c2.FirstName = "Sonu";
            c2.Lname = "Mahato";

            Console.WriteLine(c2.getFullName());

            
        }
    }
}


