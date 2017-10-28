using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Calc
    {
        [Obsolete("Use add(List<int> list1) Method",true)]//customized message in attribute
        //true=error, not able to use it

        public static int add(int a,int b)
        {
            return a + b;
        }
        [Obsolete]//outdated function
        public static int add(int a, int b, int c)//old fujnction
        {
            return a + b+c;
        }

        public static int add(List<int> list1)//for any amount of numbers, new function
            
        {
            int sum=0;
            foreach(int num in list1)
            {
                sum+= num;
            }
            return sum;
        }
    }
    
    
       
    
    class Program
    {
        static void Main(string[] args)
        {
            Calc.add(2, 3);//warning for obselete func
            List<int> nums1 = new List<int>() { 1,2,4};
            nums1.Add(1);
            nums1.Add(2);
            Calc.add(nums1);

        }
    }
}
