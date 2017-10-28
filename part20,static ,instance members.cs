using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{ 
    class Circle
    {
        static float pi = 3.141F;//pie value doesnt change, no metter what instance the object be.
        int radius;

        static Circle()//static constructors,
            //automatic calling, whenevr  we refer to any static field 
            //we initialize static fields
            //this constructior is only called once...
            //they are called before instance constriuctor
        {
            //we can initialioze pi here.
            //Circle.pi=3.14;
        }

        public Circle(int x)
        {
            this.radius = x;
        }
        public float CalcArea()
        {
            return pi * radius * radius;//cannot apply this to pie.
            float bb=Circle.pi;//can be accesed directly, without any instansiation.
        }
        public static void  print()
        {

        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            

            Circle c1 = new Circle(2);
            float a1 = c1.CalcArea();
            Console.WriteLine("the area is: {0}", a1);

            Circle c2 = new Circle(5);
            float a2 = c2.CalcArea();
            Console.WriteLine("the area is: {0}", a2);

            //deifferent object creation, duplicates all the fields, imagine 1000 classes instance 
            //duplication 10000 of fields, so we mark a field which doesnt change as static.öthe copy of pie will be shared 
            //by all instances., these also apply to functions....any class memebers

            Circle.print();//accessing a static function




        }
    }
}
