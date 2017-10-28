using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleApp1
{//Exam0ples of reflections, late binding.............
    public class Customer
    {
        public int id { set; get; }
        public string Name { set; get; }
        public Customer()
        {
            this.id = 0;
            this.Name = "Abishek";
        }
        public Customer(int x,string y)
        {
            this.id = x;
            this.Name = y;
        }
        public void print()
        {
            Console.WriteLine("id:{0} Name:{1}",id,Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("System.String");//fully qualified name or 3 alternates
            // T can also be used to inspect isarray,isstring... and many other
            //or, Type T=typeof(Customer);
            //or, Customer c1=new Customer();
            //type T=c1.GetType();
            Console.WriteLine(T.FullName);
            Console.WriteLine(T.Name);
            Console.WriteLine(T.Namespace);
            PropertyInfo[] props = T.GetProperties();//for propertyies
            foreach(PropertyInfo pis in props)
            {
                Console.WriteLine(pis.Name+"  "+pis.PropertyType.Name);
            }


            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo mis in methods)
            {
                Console.WriteLine(mis.Name+" "+mis.ReturnType.Name);
            }
            //similar way for constructors


        }
    }
}
