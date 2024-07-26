using System;

namespace PartialClassDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            StudentPartial obj = new StudentPartial();
            obj.FirstName = "Keshav";
            obj.LastName = "Kumar";
            Console.WriteLine("Your complete name is : " + obj.getCompleteName());
            Console.WriteLine();
        }
    }
}
