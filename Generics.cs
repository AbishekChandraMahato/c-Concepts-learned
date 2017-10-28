using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleApp1
{//Generics

    public class Calc
    {
        //public static bool AreEQual(int value1,int value2)
        //{
        //    return value1 == value2;
        //}
        //the above method works for only int data type, so--

        //public static bool AreEqual(object o1,object o2)
        //{
        //    return o1 == o2;
        //}
        //now, it works for any data type, still the comparison is not efficient.. so
        //we need to use generics
        public static bool AreEqual<T>(T x,T y)
        {
            return x.Equals(y);
        }
        //now we get a fully general function, strongly typed
        //similarly classes, interfaces, delegates can also be made generics.
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calc.AreEqual<int>(4,2);//testing strings
            if (equal)
            {
                Console.WriteLine("Nums are equal");
            }
            else
            {
                Console.WriteLine("nums are not equal");
            }
        }
    }
}
