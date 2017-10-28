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
        public string type { set; get; }
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
                Salary=2000,
                type="Retail"
                
            
            };
            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "Bikash",
                Salary = 3000,
                type="Bulk"

            };
            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "Rabin",
                Salary = 4000,
                type="Retail"


            };
            Customer c4 = new Customer()
            {
                ID = 104,
                Name = "Maya",
                Salary = 6000,
                type = "Corporate"


            };
            Customer c5 = new Customer()
            {
                ID = 105,
                Name = "Sushmita",
                Salary = 5000,
                type = "Cosporate"


            };


            List<Customer> customers = new List<Customer>();
            customers.Add(c1);//adding elements
            customers.Add(c2);
            customers.Add(c3);

            List<Customer> customersCorporate = new List<Customer>();
            customersCorporate.Add(c4);//adding elements
            customersCorporate.Add(c5);


            customers.AddRange(customersCorporate);//functionto add another list, range of objects

            foreach(Customer c in customers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            }


            List<Customer> lic= customers.GetRange(3,2);//function to get range of obj, startinf index 3, get 2 elements

            customers.Insert(0,c3);//inserting an obj at ind 0
            customers.InsertRange(1,customersCorporate);//inserting a range starting from ind 1

            customers.Remove(c1);//removing particular obj
            customers.RemoveAt(2);//at particular index
            customers.RemoveAll(cust=>cust.type=="Corporate");//removinf according to condition

            customers.RemoveRange(0,2);//start from o ind and then remove 2 items following


            //sorting list of simple types:

            List<int> listInt = new List<int>() { 1, 5, 6, 3, 2, 5, 8, 3, 0 };
            listInt.Sort();//ascending order
            listInt.Reverse();//now in descending order:
            foreach(int i in listInt)
            {
                Console.WriteLine(i);
            }
            //similarly: for string
            List<string> listString = new List<string>() { "abishek", "Bikash", "Sandesh", "Prabhat", "zoo" };
            listString.Sort();
            listString.Reverse();
            foreach (string i in listString)
            {
                Console.WriteLine(i);
            }

            





        }
    }
}
