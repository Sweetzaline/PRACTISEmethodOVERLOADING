using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Learn Method Overloading. \n");
           
            Program obj = new Program();
            obj.Test(); //Calling First Method.
            obj.Test(24); //Calling Second Method.
            obj.Test("Sweety"); //Calling Third Method.
            obj.Test(1, "Sweety"); //Calling Fourth Method.
            obj.Test("Asha", 2); //Calling Fifth Method.
            Console.ReadLine();
        } 
    
        public void Test()
        {
            Console.WriteLine("First Method.");
        }
        public void Test(int i)
        {
            Console.WriteLine("Second Method.");
        }
        public void Test(string s)
        {
            Console.WriteLine("Third Method.");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("Fourth Method.");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("Fifth Method.");
        }
        //public string Test() //INVALID  method with same name. Because, change in the RETURN TYPES.(AMBUIGUITY PROBLEM)
        //{                    //Only change in parameters can be consideration, like above.

        //}
    }
}
