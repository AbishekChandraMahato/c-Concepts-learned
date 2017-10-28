using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectTeam.TeamA;
using fromteamB = projectTeam.TeamB;//alias names for quicjk access

namespace projectTeam
{

    namespace TeamA
    {
        class Abc
        {
            public static void Print()
            {
                Console.WriteLine("Hello from team A function");
            }
        }
    }
}


namespace projectTeam
{

    namespace TeamB
    {
        class Abc
        {
            public static void Print()
            {
                Console.WriteLine("Hello from team B function");
            }
        }
    }
}
namespace From_part18
{
    class Program
    {
        static void Main(string[] args)
        {
            Abc.Print();
            projectTeam.TeamB.Abc.Print();//fully qualified or using in header, is ok when they have same class names.
            fromteamB.Abc.Print();//quick access using alias

        }
    }
}
