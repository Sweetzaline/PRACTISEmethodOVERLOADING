using System;

namespace MethodOverLoadingParentClass
{
    class Class1
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show method is called.");
        }
    }

    class Class2 : Class1
    {
        public void Show(int i) //OverLoading Parent's method under child class, No permission is needed.
        {
            Console.WriteLine("Child's Show method is called.");
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Let's learn Method Overriding.\n");
            Class2 obj = new Class2();
            obj.Show();//Calling Parent's method by using Child class object.Inheriting
            obj.Show(10);//Caling Same name method of child class, by OverLoading.
            Console.ReadLine();
        }

    }
}
