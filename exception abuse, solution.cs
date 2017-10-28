using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Exception handling abuse.
    
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter num1: ");
                //i/*nt a = Convert.ToInt32(Console.ReadLine());*/
                int a;
                bool x=Int32.TryParse(Console.ReadLine(), out a);
                if (x)
                {
                    Console.WriteLine("Enter num2: ");
                    int c;
                    bool y = Int32.TryParse(Console.ReadLine(),out c);
                    if(y && c!= 0)
                    {
                        int res = a / c;
                        Console.WriteLine("Result: " + res);
                    }
                    else
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Denominator cannot be 0");
                        }
                        else
                        {
                            Console.WriteLine("number out of range, must be:  " + Int32.MaxValue + "-(" + Int32.MinValue + ")");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("number out of range, must be:  " + Int32.MaxValue + "-(" + Int32.MinValue + ")");
                }

                //Console.WriteLine("Enter num2: ");
                //int b = Convert.ToInt32(Console.ReadLine());

                //int res = a / b;
                //Console.WriteLine("Result: " + res);
            }
            //replaced by logical flow
            //catch (FormatException)
            //{
            //    Console.WriteLine("Plz enter numbers");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("number out of range, must be:  "+Int32.MaxValue+"-("+Int32.MinValue+")");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Divident cannot be zero");
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


    }
}
