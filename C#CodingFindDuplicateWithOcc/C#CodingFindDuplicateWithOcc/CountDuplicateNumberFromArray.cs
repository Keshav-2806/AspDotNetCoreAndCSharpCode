using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CodingFindDuplicateWithOcc
{
    internal class CountDuplicateNumberFromArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of Element");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Enter Element");
                int element = Convert.ToInt32(Console.ReadLine());
                array[i] = element;
            }

            Dictionary<int,int> dict = new Dictionary<int, int>();
            foreach (int item in array)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            foreach (var pair in dict.Keys)
            {
                Console.WriteLine("Value:  "+ pair + "   occurrence :" + dict[pair]);
            }
        }
   
    }
}
