using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleApp1
{//Exam0ples of reflections, late binding.............
    public class Customers
    {
        public int id { set; get; }
        public string Name { set; get; }
        public Customers()
        {
            this.id = 0;
            this.Name = "Abishek";
        }
        public Customers(int x,string y)
        {
            this.id = x;
            this.Name = y;
        }
        public void print()
        {
            Console.WriteLine("id:{0} Name:{1}",id,Name);
        }
        public string prints(string x,string y)
        {
            return y + " id:" + x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //**early binding, to instantiate the class specefically, as we know the scope and composition of it!
            //Customer c1 = new Customer(101,"Abishek");
            //c1.print();

            //**late binding!, we dont have knowledge of the class at compile time!
            //lets imagine there is n o Customer Class for now

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType=executingAssembly.GetType("ConsoleApp1.Customers");

            object customerinstance=Activator.CreateInstance(customerType);
            MethodInfo getprintMethod= customerType.GetMethod("prints");

            string[] parameters = new string[2];
            parameters[0] = 222.ToString();
            parameters[1] = "Chandra";

            string retu=getprintMethod.Invoke(customerinstance, parameters).ToString();

            Console.WriteLine(retu);

        }
    }
}
