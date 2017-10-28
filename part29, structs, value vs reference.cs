using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Classes
{
    //structures definations, eg. int value type unlike of class which is reference type
    public sealed class SealedClass//cannot act as a base class, being inherited
    {

    }
    public struct Struct1
    {
        private int _id;
        private string _name;
        //no parameter less constructors
        //no inheritance from structs
        public Struct1(int x,string y)
        {
            this._id = x;
            this._name = y;
        }
        //no destructors
        //public properties
        public int ID
        {
            set { this._id = value; }
            get { return this._id; }
        }
        public string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }
        //public functions:
        public string getString()
        {
            return "ID: " + this._id + "Name: " + this._name;
        }
    }
    class Program
    {


        static void Main(string[] args)

        {
            //3 different methods of initializing classes or structs:
            string ss;
            Struct1 st1 = new Struct1();
            st1.ID = 101;
            st1.Name = "Abishek";
            ss = st1.getString();
            //above is normal instantiation method, below a new one
            //is called object initializer syntax:

            Struct1 st3 = new Struct1
            {
                ID = 103,
                Name="Mamata"
                

            };
            

            Console.WriteLine(ss);

            Struct1 st2 = new Struct1(102,"Mahato");
            Console.WriteLine(st2.getString()) ;

            //reference type copying:, changes in one effects the otehr
            Struct1 s1=new Struct1();
            s1 = st1;
            Console.WriteLine(s1.Name);
            st1.Name = "Bikki";
            Console.WriteLine(st1.Name);

        }
    }
}
