using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{ 
    class Customer
    {
        string _firstName;
        string _lastname;
        public Customer()//non-parameterized
           :this("a","b")//calling other constructor for parameters
        {
            
           

        }
        public Customer(string a,string b)//constructor parameterized
        {
            this._firstName = a;
            this._lastname = b;
        }
        ~Customer()//destructors
        {
            //clean up code
        }
        public void Print()
        {
            Console.WriteLine("Fname: {0} \nLname:{1} \n",_firstName,_lastname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer("Abishek", "Mahato");
            c1.Print();

            Customer c2 = new Customer();//no data provided , calling to default constructor
            c2.Print();

            

            
        }
    }
}
