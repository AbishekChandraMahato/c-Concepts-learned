using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleApp1
{
    //async and await! 
    



        public class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }
    class Program
    {

        public static int CountCharacters()
        {
            int count = 1000;
            Thread.Sleep(5000);

            return count;

        }
        public async  static void  Func()//asyn func with await
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            Console.WriteLine("Processing file , please wait!....");
            int count = await task;
        }
         static void Main(string[] args)
        {

            
            Program.Func();
            Program.CountCharacters();


        }

    }
}
