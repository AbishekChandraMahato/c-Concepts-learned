using System;

namespace FromInterface
{


    class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }//gender of enum Gender type
        //0-unknown,1-male,2-femlae
    }
    //enum creation
    //the default underline type is integer, starting from 0
    public enum Gender//possible to change underline type :short
    {
        xx=1,//now index starting from 1
        unknown,
        Male,
        Female,
        xxx=10//the range of number depends on the type
        
    }
    public enum Seasons
    {
        winter=1,
        spring=2,
        summer=3
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //accessing the inetegers;
            int[] values=(int[])Enum.GetValues(typeof(Gender));
            foreach(int val in values)
            {
                Console.WriteLine(val);
            }
            //accessing the names
            string[] values1 = (string[])Enum.GetNames(typeof(Gender));
            foreach(string  val in values1)
            {
                Console.WriteLine(val);
            }
            //Gender gender = 3;//not possible, implicitly

            Gender gender = (Gender)6;
            //int num = Gender.unknown;//not possible
            int num = (int)Gender.Male;//explicit conversion is needed



            //Gender gender = Seasons.spring;//not allowed implicitly
            Gender g1 = (Gender)Seasons.summer;
            Seasons s1 = (Seasons)Gender.xx;
        }
    }
}
