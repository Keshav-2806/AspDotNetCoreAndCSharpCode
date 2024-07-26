using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseDemo
{
     class SumOfDigits
    {
        static void Main()
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int reminder;
            while (number > 0)
            {
                reminder = number % 10;
                sum=sum+reminder;
                number = number / 10;
            }
            Console.WriteLine($"The sum of Digits is: {sum}");
        }
    }
}
