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


            List<Customer> customers = new List<Customer>(100);
            customers.Add(c1);//adding elements
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);


            Console.WriteLine( customers.TrueForAll(x => x.Salary > 3000));//it should be true for all , to get true, else it is false


            IReadOnlyCollection<Customer> readOnlyList= customers.AsReadOnly();//now we have read only list!

            Console.WriteLine(customers.Capacity);
            Console.WriteLine(customers.Count());

            customers.TrimExcess();//its makes capacity and count equal, memory saving

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(customers.Capacity);
            Console.WriteLine(customers.Count());





        }
    }
}
