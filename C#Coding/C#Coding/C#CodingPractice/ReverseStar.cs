using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Coding.C_CodingPractice
{
     class ReverseStar
    {
        static void Main()
        {
            Console.WriteLine("Enter Number ");
            int n = Convert.ToInt32(Console.ReadLine());
           for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}
