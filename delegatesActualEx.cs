using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //delegateUsage
    delegate bool IsPromotable(Employee emp1);
    class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }
        public int Experience { set; get; }

        public static void PromoteEmployee(List<Employee> employeeList,IsPromotable IsEligibleToPromote)
        {
            foreach(Employee employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
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

            IsPromotable d1 = new IsPromotable(Promote);
            Employee.PromoteEmployee(empList,d1);//passing the delegate or instead of passing
            //delegate, we can using lambda expressions.
            
        }
        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
                return false;
        }
        
    }
}
