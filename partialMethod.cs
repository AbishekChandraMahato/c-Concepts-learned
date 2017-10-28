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

        partial void samplePartialMethod();//partial method defination
        //implementation can also be done, but are divided 

        public void PublicMethod()
        {
            Console.WriteLine("public method invoked!");
            samplePartialMethod();
        }
    }
}


partitioned

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
        partial void samplePartialMethod()//implementation of partial method
        {
            Console.WriteLine("Partial method invoked");
        }

    }
}
