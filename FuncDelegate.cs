using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleApp1
{
    //Func Delegate



        public class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Employee> employeelist = new List<Employee>()
            {
                new Employee{ID=101,Name="Abishek"},
                new Employee{ID=102,Name="Bikash"},
                new Employee{ID=103,Name="Chandra"},

            };
            //Func delegate, input parameters may be two or more!
            Func<Employee, string> selector = employee => "Name= " + employee.Name;
            //another method, passing the lambda expression to IEnumerable, like: instead of func delegate'
            //IEnumerable<string> names = employeelist.Select(employee => "Name= " + employee.Name);
            IEnumerable<string> names = employeelist.Select(selector);

            foreach(string ss in names)
            {
                Console.WriteLine(ss);
            }
            
            

        }

    }
}
