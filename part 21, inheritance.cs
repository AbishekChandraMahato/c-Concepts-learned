using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Inheritance:
namespace Classes
{ 
    
    public class Employee
    {
        public string fname;
        public string lname;
        public string email;

        public Employee()
        {
            Console.WriteLine("Parent constructor");
        }
        public Employee(string mssg)
        {
            Console.WriteLine(mssg);
        }

        public void PrintFullName()
        {
            Console.WriteLine("Fname: {0}\n Lname: {1}", fname, lname);

        }
    }

    public class FullTimeEmplopyee : Employee
    {
        public float yearlySalary;
        public FullTimeEmplopyee() : base("abcdef")//changing the call of parents constructor
        {
            Console.WriteLine("child constructor");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
    }
    class Program
    {
        static void Main(string[] args)
        {


            FullTimeEmplopyee f1 = new FullTimeEmplopyee();
            f1.fname = "Pragim";
            f1.lname = "Tech";
            f1.yearlySalary = 452442.145f;
            f1.PrintFullName();

            PartTimeEmployee p1 = new PartTimeEmployee();
            p1.fname = "Tech";
            p1.lname = "Pragim";
            p1.hourlyRate = 12.88f;
            p1.PrintFullName();


        }
    }
}
