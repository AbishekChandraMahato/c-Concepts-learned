using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //multicast Deligate>
    public delegate void SampleDelegate();//single delegate will point to multiple functions.
    class Program
    {
        static void Main(string[] args)
        {
            //SampleDelegate d1 = new SampleDelegate(SampleMethodOne);
            //d1();

            SampleDelegate d1, d2, d3,d4,d5;
            d1 = new SampleDelegate(SampleMethodOne);
            d2 = new SampleDelegate(SampleMethodTwo);
            d3 = new SampleDelegate(SampleMethodThree);

            d4 = d1 + d2 + d3;//d4 pointing to all 3 delegates instances
            //method can also be removed by using minus sign.
            d4();//so, calling all four functions at a time.'d4' is called multicast delegate

            //method of registering and unregistering functions/multiple  to delegate
            d5 = new SampleDelegate(SampleMethodOne);
            d5 += SampleMethodTwo;
            d5 += SampleMethodThree;
            d5 -= SampleMethodThree;//unregistering a func.

            d5();






        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample methoid1");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample methoid2");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample methoid3");
        }
        


    }
}
