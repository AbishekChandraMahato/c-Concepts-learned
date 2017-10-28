using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleApp1
{


    public class Customer
    {
        public string fname { set; get; }
        public string lname { set; get; }

        public override bool Equals(object obj)//overriding Equals
        {
            if (obj == null)
            {
                return false;
            }
            if(!(obj is Customer))
            {
                return false;
            }
            return this.fname == ((Customer)obj).fname && this.lname == ((Customer)obj).lname;//equality on the basis of values;
        }
        public override int GetHashCode()
            //its good practice that we ovveride this func along with Equals
        {
            return this.fname.GetHashCode() ^ this.lname.GetHashCode();
        }
    }
    public enum direction
    {
        east=1,
        west=2,
        north=3,
        south=4
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;

            Console.WriteLine(i==j);
            Console.WriteLine(i.Equals(j));//Equals method

            direction d1 = direction.west;
            direction d2 = direction.east;

            Console.WriteLine(d1==d2);

            Customer c1 = new Customer();
            c1.fname = "Abishek";
            c1.lname = "Mahato";

            //Customer c2 = c1;

            //Console.WriteLine(c1 == c2);//refernce and value equality
            //Console.WriteLine(c1.Equals(c2));



            Customer c3 = new Customer();//values are equal with c1 , but refernce are different
            c3.fname = "Abishek";
            c3.lname = "Mahato";

            Console.WriteLine(c1 == c3);//false, although the values ae same, so we need to overrride Equals Methoid
            Console.WriteLine(c1.Equals(c3));//true after overriding Equals func, 

        }
    }
}
