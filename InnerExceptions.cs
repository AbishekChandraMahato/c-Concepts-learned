using System;
using System.IO;
using print = System.Console;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1
{
    //inner exceptions:

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                try
                {
                    Console.WriteLine("Enter num1: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter num2: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    int res = a / b;
                    Console.WriteLine("Result: " + res);
                }
                catch (Exception ex)
                {
                    string file1 = "lo.txt";
                    if (File.Exists(file1))
                    {
                        FileStream f1 = new FileStream(file1, FileMode.OpenOrCreate);

                        StreamWriter sr1 = new StreamWriter(f1);
                        sr1.WriteLine(ex.GetType().Name);
                        sr1.Dispose();
                        Console.WriteLine("theres a problem , please try again later:" + ex.GetType().Name);
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------");
                        throw new FileNotFoundException(file1 + " is not found", ex);//inner exception throw
                    }
                }
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Current Exception: "+ex1.GetType().Name);//outer exception catch
                Console.WriteLine("------------------------------------------");
                if (ex1.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex1.InnerException.GetType().Name);//inner exception catch
                }
            }


        }


    }
}
