using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    
    
    class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }
        public int Experience { set; get; }

        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach(Employee employee in employeeList)
            {
                if (employee.Experience >= 5)//these are hard codd logic, not re-usable there comes delegates 
                {
                    Console.WriteLine(employee.Name+" is promoted");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Abishek Mahato",Salary=200000,Experience=5 });
            empList.Add(new Employee() { ID = 102, Name = "Sonu Mahato", Salary = 300000, Experience = 2 });
            Employee.PromoteEmployee(empList);
            
        }
        
    }
}
