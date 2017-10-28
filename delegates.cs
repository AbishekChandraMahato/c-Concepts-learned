using System;

namespace ConsoleApp1
{
    //delegates>
    public delegate void hellofuncDelegate(string messg);
    //it points to any other func which as void return type 
    //
    

    class Program
    {
        static void Main(string[] args)
        {
            hellofuncDelegate d1 = new hellofuncDelegate(hello);//instance of delegate 
            //pointing to a function
            d1("Hello from delegate");//parameters passing

        }
        public static  void hello(string mssg)
        {
            Console.WriteLine(mssg);

        }
    }
}
