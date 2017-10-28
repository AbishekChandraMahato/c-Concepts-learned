using System;

namespace FromInterface
{
   interface I1
    {
        void interfaceMethod();//same function
    }
    interface I2
    {
        void interfaceMethod();//same function
    }
    class Program:I1,I2
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            

            ((I1)p1).interfaceMethod();//explicit implementation, type casting
            ((I2)p1).interfaceMethod();

            //another method

            I1 i1 = new Program();
            i1.interfaceMethod();
            
        }

        void I1.interfaceMethod()//explicit implementation
            //so that we know which function we r actually calling
            //no modifiers allowed in function
        {
            Console.WriteLine("I1 interface method called");
        }
        void I2.interfaceMethod()
        {
            Console.WriteLine("I2 interface method called");
        }
    }
}
