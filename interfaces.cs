using System;

namespace FromInterface
{
    interface ICustomer
    {
        void print();//declarations
    }
    interface I2
    {
        void i2method();
    }
    interface Sample:I2
    {
        void samplePrint();
    }
    class Customer:ICustomer,I2
    {
        public void i2method()
        {
            Console.WriteLine("another method implementation of another interface to same class");
        }

        public void print()//implementation from interface
        {
            Console.WriteLine("this is implementation of a function from interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.print();
            //no instantiation of an interface, only declaration

            ICustomer i1 = new Customer();
            i1.print();
            
        }
    }
}
