using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student
    {
        private int _id;
        private string _name;
        private int passmark=35;
        //auto implemented property
        //if theres no logic control required
        public string name {
            get;
            set;
        }

        //setters and getters
        public int id//a property with set and get .
        {
            set
            {
                if (value <= 0)//value keyword
                {
                    throw new Exception("invalid data");
                }
                else
                {
                    this._id = value;
                }
            }
            get
            {
                return this._id;
            }
        }
        

    }

    class Program
    {


        static void Main(string[] args)

        {
            Student s1 = new Student();
            s1.id = 12;
            Console.WriteLine(s1.id);

            



        }
    }
}
