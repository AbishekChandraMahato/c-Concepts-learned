using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{ 
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("func from base class");
        }
    }
    public class DerivedClass:BaseClass
    {
        public override void Print()//if we want to invoke the base class member by pointing to child class obj
            //we can use new instead of override, thats method hiding.
        {
            Console.WriteLine("func from derived class");
        }
    }
   
    class Program
    {
        static void Main(string[] args)

        {
            BaseClass b1 = new DerivedClass();
            b1.Print();




        }
    }
}
