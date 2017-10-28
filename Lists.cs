
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Customer
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }
    }
    public class SavingsCustomer : Customer
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //instantiation of objects
            Customer c1 = new Customer()
            {
                ID = 101,
                Name = "Abishek",
                Salary=2000
                
            
            };
            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "Bikash",
                Salary = 3000


            };
            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "Rabin",
                Salary = 4000


            };

            List<Customer> customers = new List<Customer>(2);
            customers.Add(c1);//adding elements
            customers.Add(c2);
            customers.Add(c3);

            customers.Insert(1,c3);//put objects at any index required
            customers.IndexOf(c1);//finding index of a particular obj
            Console.WriteLine(customers.IndexOf(c3));
            Console.WriteLine(customers.IndexOf(c3,2));//finding index of a particular obj, starting from ind 2
            Console.WriteLine(customers.IndexOf(c3, 2,2));//finding index of a particular obj, starting from ind 2 and lookup only two elements after it.
            Customer cc = customers[2];

            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", cc.ID, cc.Name, cc.Salary);
            Console.WriteLine("---------------------------------------------------");
            //for each loop
            foreach(Customer ccc in customers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", ccc.ID, ccc.Name, ccc.Salary);
            }
            Console.WriteLine("---------------------------------------------------");
            //for loop
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", customers[i].ID,customers[i].Name,customers[i].Salary);
            }

            SavingsCustomer sc1 = new SavingsCustomer();
            customers.Add(sc1);//adding an inherited object
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();
            //different associated functions
            if (customers.Contains(c1))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }


            if(customers.Exists(cust=> cust.Name.StartsWith("B")))//specifying a condition to find
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Doesnt exists");
            }

            Customer cn= customers.Find(cust=>cust.Salary>2000);//gives the first matching element , according to condition
            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", cn.ID, cn.Name, cn.Salary);

            Customer cnn = customers.FindLast(cust => cust.Salary > 2000);//gives the last matching element , according to condition
            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", cnn.ID, cnn.Name, cnn.Salary);

            Console.WriteLine("---------------------------------------------------");
            List<Customer> custs = customers.FindAll(cust=>cust.Salary>500);//gives a list of obj , according to condition!
            
            foreach(Customer cuu in custs)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", cuu.ID, cuu.Name, cuu.Salary);
            }

            int ind=customers.FindIndex(cust => cust.Salary == 2000);
            Console.WriteLine(ind);
            //overloads
            int indx = customers.FindIndex(0,cust => cust.Salary == 2000);
            int indxx = customers.FindIndex(0,2,cust => cust.Salary == 2000);

            //same goes with FindLastIndex();

            //conversion of Lists:

            Customer[] cusss = new Customer[3];
            cusss[0] = c1;
            cusss[1] = c2;
            cusss[2] = c3;

            List<Customer> List1 = cusss.ToList();//array to list

            customers.ToArray();//list to array

            Dictionary<int,Customer> dic1= List1.ToDictionary(x=>x.ID);//list to dictionary






        }
    }
}
