
//static void PassByValue(int a)
//{
//    a = a + 10;
//    Console.WriteLine("Value of a is :" + a);
//}

//    int value = 5;
//    PassByValue(value);
//    Console.WriteLine(value);


//int a = 5;
//static void PassByRef(ref int a)
//{
//    a = a + 10;
//    Console.WriteLine("value is " + a);
//}

//PassByRef(ref a);
//Console.WriteLine(a);


//int value;
//static void PassByOut(out int a)
//{
//    a = 20;
//    Console.WriteLine("value is " + a);
//}

//PassByOut(out value);
//Console.WriteLine(value);





using System.Runtime.CompilerServices;

namespace CSharpBasicPractice
{

  static   class Anjali
    {
        /*   public int id;*///con not create instance variable in static class
        static int id;
        static string name;
        static Anjali( )
        {
            id = 1;
            name = "Anjali";
        }
       public static void GetDetails()
        {
            Console.WriteLine("static C is  invoked {0} ", id);
            Console.WriteLine("static C is  invoked {0} ", name);
        }
    }

    class Example
    {
        public static int a;
        private Example()
        {
            
        }
        public static int  GetIncrement()
        {

            Console.WriteLine(a);
            return ++a;
        }

    }


    class Program
    {
       
      public Program() 
        {
            Console.WriteLine("Constructor invoked...");
        }

        static Program()
        {
            Console.WriteLine("Static constructor invoked...");
        }
        static void Main(string[] args)
        {
            // Anjali a = new Anjali();
            // Anjali.GetDetails();
            // Program p = new Program();
            // program p1 = new program();

           Console.WriteLine( Example.GetIncrement());

            Console.ReadLine();
        }
    }
}