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
        public static int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
        static void Main(string[] args)
        {
            //instantiation of objects
            Customer c1 = new Customer()
            {
                ID = 1011,
                Name = "Abishek",
                Salary=20000,
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

            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);
            //method1:
            //customers.Sort(customerComparer);


            foreach (Customer c in customers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            }


            //another method1

            customers.Sort(delegate(Customer cx,Customer cy){ return c1.ID.CompareTo(c2.ID); });

            //another method 2, lambda

            customers.Sort((x, y) => x.ID.CompareTo(y.ID));

        }
    }
}
