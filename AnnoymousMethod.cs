using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    //anonymous methods:



        public class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }
    class Program
    {
        //step 1 , a function
        //public static bool findEmployee(Employee emp)
        //{
        //    return emp.ID == 102;
        //}
        static void Main(string[] args)
        {
            List<Employee> employeelist = new List<Employee>()
            {
                new Employee{ID=101,Name="Abishek"},
                new Employee{ID=102,Name="Bikash"},
                new Employee{ID=103,Name="Chandra"},

            };
            ////step 2, an instance of an delegate
            //Predicate<Employee> employeePredicate = new Predicate<Employee>(findEmployee);
            //step 3 , passed deleagte instance as a parameter
           Employee emps= employeelist.Find(delegate(Employee ee)
           {
               return ee.ID == 102;
               //anonymous method in action
           }
           
           
           
           
           );

            Console.WriteLine(emps.ID +"  "+ emps.Name);



        }

    }
}
