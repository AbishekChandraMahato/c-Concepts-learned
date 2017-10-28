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


            List<Country> dic1 = new List<Country>(100);
            dic1.Add(c1);//adding elements
            dic1.Add(c2);
            dic1.Add(c3);
            dic1.Add(c4);
            dic1.Add(c5);
            //string choice = "";
            //do
            //{
            //    Console.WriteLine("Plz enter a country code:");
            //    string cc = Console.ReadLine().ToUpper();

            //    Country resultCountry = dic1.Find(count => count.code == cc);

            //    if (resultCountry == null)
            //    {
            //        Console.WriteLine("Not valid Country Code");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Name: {0},Capital: {1}", resultCountry.Name, resultCountry.capital);
            //    }
            //    Console.WriteLine("Do u wanna continue? y/n");
            //    choice = Console.ReadLine().ToUpper();
            //}
            //while (choice == "Y");

            //fo this , list is not efficient, delegate is an efficient method, time factor, using keys
            //peformance is better with delegate:

            Dictionary<string, Country> dicc1 = new Dictionary<string, Country>();
            dicc1.Add(c1.code, c1);
            dicc1.Add(c2.code, c2);
            dicc1.Add(c3.code, c3);
            dicc1.Add(c4.code, c4);
            dicc1.Add(c5.code, c5);

            string choice = "";
            do
            {
                Console.WriteLine("Plz enter a country code:");
                string cc = Console.ReadLine().ToUpper();

                Country resultCountry = dicc1.ContainsKey(cc) ? dicc1[cc]:null;//first checking the key, and then accessing!, more efficient than list and faster

                if (resultCountry == null)
                {
                    Console.WriteLine("Not valid Country Code");
                }
                else
                {
                    Console.WriteLine("Name: {0},Capital: {1}", resultCountry.Name, resultCountry.capital);
                }
                Console.WriteLine("Do u wanna continue? y/n");
                choice = Console.ReadLine().ToUpper();
            }
            while (choice == "Y");







        }
    }
}
