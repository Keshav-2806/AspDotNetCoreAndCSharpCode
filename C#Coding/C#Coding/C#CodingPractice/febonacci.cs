using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Coding.C_CodingPractice
{
    class febonacci
    {
        static void Main()
        {
            Console.WriteLine("Enter range");
            int n = Convert.ToInt32 (Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;
            for (int i = 0; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b=temp;
                Console.WriteLine(temp);

            }
            
            
        }
    }
}
