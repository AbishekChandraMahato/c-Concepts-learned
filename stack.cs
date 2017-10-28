using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
   
    public class Country
    {
        public string code { set; get; }
        public string Name { set; get; }
        
        public string capital { set; get; }

       
    }
   
    class Program
    {
        
        static void Main(string[] args)
        {
            //instantiation of objects
            Country c1 = new Country()
            {
                code="AUS",
                Name="Australia",
                capital="Canberra"
                
            
            };
            Country c2 = new Country()
            {
                code="IND",
                Name="India",
                capital="New Delhi"

            };
            Country c3 = new Country()
            {
                code="USA",
                Name="United States of America",
                capital="Washington DC"


            };
            Country c4 = new Country()
            {
               code="GBR",
               Name="United kingdom",
               capital="London"


            };
            Country c5 = new Country()
            {
                code="CAN",
                Name="Canada",
                capital="Ottawa"


            };


            Stack<Country> stk = new Stack<Country>();
            stk.Push(c1);//adding one over the other
            stk.Push(c2);
            stk.Push(c3);
            stk.Push(c4);
            stk.Push(c5);

            Country cc1=stk.Pop();//removing the top element
            Console.WriteLine(cc1.code);
            Console.WriteLine(stk.Count());

            foreach(Country c in stk)
            {
                Console.WriteLine(c.code);
            }

            Country co=stk.Peek();//returns the top obj withour removing it!

            bool g = stk.Contains(c3);
            Console.WriteLine(g);

        }
    }
}
