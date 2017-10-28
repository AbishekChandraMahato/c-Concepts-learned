using System;

namespace FromInterface
{
   public abstract  class  Customer
    {
        public abstract void print();//abstract function
        public void func1()//non-abstract member
        {

        }
    }
    
    public class Program:Customer//if wishes not to implement 
        //then, make this class abstract.
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.print();
            //or from polymorphism
            Customer c1 = new Program();
            c1.print();
            
        }
        public override void print()//implementation , override
        {
            Console.WriteLine("abstract func from abstract xlass");
        }
        
    }
}
