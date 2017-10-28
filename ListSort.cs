using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class sortbyName : IComparer<Customer>//a customized class for sorting on the basis of name
    {
        public int Compare(Customer x,Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Customer:IComparable<Customer>//enabling sorting on certain criteria
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }
        public string type { set; get; }

        public int CompareTo(Customer other)//sorting on the basis of Salary:
        {
            if (this.Salary > other.Salary)
            {
                return 1;
            }
            else if (this.Salary < other.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }

            //besides, writing the multiple lines, :
            //return this.Salary.CompareTo(other.Salary);
        }
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


            List<Customer> customers = new List<Customer>();
            customers.Add(c1);//adding elements
            customers.Add(c2);
            customers.Add(c3);

            //List<Customer> customersCorporate = new List<Customer>();
            //customersCorporate.Add(c4);//adding elements
            //customersCorporate.Add(c5);


            //customers.AddRange(customersCorporate);//functionto add another list, range of objects
            //now sortin is possible
            customers.Sort();//sort on the basis of salary:
            customers.Reverse();
            foreach(Customer c in customers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            }


            //alternative method
            sortbyName sn = new sortbyName();
            customers.Sort(sn);//passing that instance to sort func of list

            Console.WriteLine("----------------------------------------------------------------");
            foreach (Customer c in customers)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", c.ID, c.Name, c.Salary);
            }




        }
    }
}
