using System;
using System.IO;
using print = System.Console;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            
            string file = "ac.txt";
            try
            {
                FileStream f1 = new FileStream(file, FileMode.Open, FileAccess.Read);
                

                StreamReader sr1 = new StreamReader(f1);

                Console.WriteLine(sr1.ReadToEnd());
            }
            //specific
            catch(FileNotFoundException ex)//special exception from Exception, so, a practical example of Inheritance.
            {
                Console.WriteLine(ex.FileName + " not found");
            }
            //general
            catch(Exception ex) //or use FileNotFoundException, base exception
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(ex.StackTrace);
                
            }
            //for this catch pair, specefic ex should not come after general.

            finally//releasing resources:, this is gonna execute any way,its optional, which catch gets triggered, depends
            {
                
            }









        }



    }
}
