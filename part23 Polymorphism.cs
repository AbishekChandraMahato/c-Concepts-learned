using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//polymoråhism
namespace Classes
{ 
    
    public class Employee//super class for 3 child classes
    {
        public string fname="FN";
        public string lname="LN";
        public virtual void PrintFullName()//making it a virtual signifies that, any derived class
            //overrides the method, if they wish to do so
        {
            
            Console.WriteLine(fname+" "+lname);
        }
    }
    public class PartTimeEmployee:Employee
    {
        public override void PrintFullName()//overriding methods, method hiding
        {
            
        Console.WriteLine(fname + " " + lname+"PT");
        }

       
    }

    public  class FullTimeEmployee:Employee
    {
        public override void PrintFullName()//using override to signify that we want to override the 
            //base class function
        {
            Console.WriteLine(fname + " " + lname + "FT");
        }
    }

    public class TemporaryEmployee:Employee
    {
        
    }
    class Program
    {
        static void Main(string[] args)

        {
            Employee[] employees = new Employee[4];//array of Employee type
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();//parent class pointing to child object
            employees[2] = new FullTimeEmployee();//parent class pointing to child object
            employees[3] = new TemporaryEmployee();//parent class pointing to child object


            foreach(Employee e in employees)
            {
                e.PrintFullName();
            }
            //even though there are functions of their own versions in child classes too
            //it will not invoke function from child class, as base class variable is referencing child class!

            //now, after using virtual and override keywords
            //we are now able to call child class methods from
            //base class reference variable pointing to child object.//polymorphism





        }
    }
}
