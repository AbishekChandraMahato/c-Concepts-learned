using System;

namespace FromInterface
{


    class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }//gender of enum Gender type
        //0-unknown,1-male,2-femlae
    }
    //enum creation
    public enum Gender
    {
        unknown,
        Male,
        Female
    }
    class Program
    {
        public static string getGender(Gender gender)//enum type parameter
        {
            //in reality there might be many numerical integration
            //so, to remember those all numbers and relation--enum!
            //this program is less readable and less maintainable
            if (gender==Gender.Male)
            {
                return "Male";
            }
            else if (gender==Gender.Female)
            {
                return "Female";
            }
            else if (gender == Gender.unknown)//accessing the value from enum
            {
                return "Unknown";
            }
            else
                return "Invalid data detected";
            //now the program is more readable!
        }
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male//accessing the value from enum


            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = Gender.Female

            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = Gender.unknown

            };
            foreach(Customer customer in customers)
            {
                Console.WriteLine("name= {0}, Gender={1}", customer.Name, getGender(customer.Gender));
            }


        }
    }
}
