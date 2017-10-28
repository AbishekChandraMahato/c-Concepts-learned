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
            //creation of a dictionary
            Dictionary<int, Customer> d1 = new Dictionary<int, Customer>();
            //adding objects to dictionary
            d1.Add(c1.ID, c1);
            d1.Add(c2.ID, c2);
            d1.Add(c3.ID,c3);

            //accessing an object with key
            Customer cust102 = d1[102];

            //TryGetValue() function
            Customer custx;
            if (d1.TryGetValue(101, out custx))
            {
                Console.WriteLine("Id:{0} , Name: {1}, salary: {2}", custx.ID, custx.Name, custx.Salary);
            }
            else
                Console.Write("key not found");
            Console.WriteLine("Id:{0} , Name: {1}, salary: {2}", cust102.ID, cust102.Name, cust102.Salary);

            //looping through dictionary, for both key and objects
            foreach (KeyValuePair<int,Customer> kvp in d1)
            {
                Console.WriteLine("Id:{0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("Id:{0} , Name: {1}, salary: {2}", cust.ID, cust.Name, cust.Salary);

            }
            //accessing keys value only
            foreach (int k  in d1.Keys)
            {
                Console.WriteLine("Id:{0}",k);
                

            }
            //accessing values only
            foreach (Customer c in d1.Values)
            {


                Console.WriteLine("Id:{0} , Name: {1}, salary: {2}", c.ID, c.Name, c.Salary);
            }
            Customer c4 = new Customer()
            {
                ID = 102,
                Name="Mohan",
                Salary=3000
                
            };
            //checking the uniqueness, as key should be unique
            if (!d1.ContainsKey(c4.ID))
            {
                d1.Add(c4.ID,c4);
            }
            Console.WriteLine("total items in dictionary:{0}", d1.Count);
            Console.WriteLine("total items:{0}", d1.Count(kvp => kvp.Value.Salary > 2000));
            //remove a particular pair
            d1.Remove(999);
            //d1.Clear();, removes everything from dictionary

            Console.WriteLine("-----------------------------------------");
            //converting an array to dictionary:, same goes for List<>
            Customer[] cc = new Customer[3] { c1, c2, c3 };
            Dictionary<int,Customer> d2= cc.ToDictionary(cud => cud.ID, cud => cud);
            foreach (Customer c in d2.Values)
            {


                Console.WriteLine("Id:{0} , Name: {1}, salary: {2}", c.ID, c.Name, c.Salary);
            }
        }
    }
}
