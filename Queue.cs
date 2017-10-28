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


            Queue<Country> queCountry = new Queue<Country>();
            queCountry.Enqueue(c1);//adding elements
            queCountry.Enqueue(c2);
            queCountry.Enqueue(c3);
            queCountry.Enqueue(c4);
            queCountry.Enqueue(c5);


            Country cc1= queCountry.Dequeue();//removing element, removes the first element added
            Console.WriteLine("code: {0}",cc1.code);
            Console.WriteLine(queCountry.Count());//size!

            //looping through the values!!
            foreach(Country c in queCountry)
            {
                Console.WriteLine("code: {0}", c.code);
            }

            Country cc2 = queCountry.Peek();
            Console.WriteLine("code: {0}", cc2.code);//returns element at beginning of quee without removing it.


            bool y = queCountry.Contains(c4);//checking an element is present or not!
            if (y)
            {
                Console.WriteLine("exists");
            }
            else
                Console.WriteLine("doesnt exists");



        }
    }
}
