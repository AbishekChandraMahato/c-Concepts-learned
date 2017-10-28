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
        public void PrintFullName()
        {
            Console.WriteLine("Fname: {0} Lname: {1}",fname,lname);
        }
    }
    public class PartTimeEmployee:Employee
    {

        public new void PrintFullName()//hiding base class function, new is used to signify that hiding is intentional
        {
            Console.WriteLine("Fname: {0} Lname: {1}-p", fname, lname);
            //base.PrintFullName();//we are using base class function, one way to access, theres another way, type casting

        }
    }

    public class FullTimeEmployee:Employee
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

            FullTimeEmployee f1 = new FullTimeEmployee();
            f1.fname = "Abishek";
            f1.lname = "Mahato";
            f1.PrintFullName();

            PartTimeEmployee p1 = new PartTimeEmployee();
            p1.fname = "Shankar";
            p1.lname = "Narayan";
            //p1.PrintFullName();
            ((Employee)p1).PrintFullName();//calling base class function, no method hiding or another methodis:

            //Employee pp1 = new PartTimeEmployee();//another method
            //pp1.fname = "Shankar";
            //pp1.lname = "Narayan";
            //pp1.PrintFullName();




        }
    }
}
