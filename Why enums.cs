using System;

namespace FromInterface
{


    class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
        //0-unknown,1-male,2-femlae
    }
    class Program
    {
        public static string getGender(int gender)
        {
            //in reality there might be many numerical integration
            //so, to remember those all numbers and relation--enum!
            //this program is less readable and less maintainable
            if (gender == 1)
            {
                return "Male";
            }
            else if (gender == 2)
            {
                return "Female";
            }
            else if (gender == 0)
            {
                return "Unknown";
            }
            else
                return "Invalid data detected";
        }
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = 1


            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = 2

            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = 0

            };
            foreach(Customer customer in customers)
            {
                Console.WriteLine("name= {0}, Gender={1}", customer.Name, getGender(customer.Gender));
            }


        }
    }
}
