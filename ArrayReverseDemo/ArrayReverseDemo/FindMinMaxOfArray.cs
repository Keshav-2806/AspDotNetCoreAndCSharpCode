using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseDemo
{
     class FindMinMaxOfArray
    {
        public void ReverseArray() 
        {
            Console.WriteLine("Enter Size of Array");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine("Enter Element");
                int element = Convert.ToInt32(Console.ReadLine());
                array[i] = element;
            }
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < arrLength; i++)
            {
                if (array[i]<min)
                {
                    min = array[i];
                }
                if (array[i]>max)
                {
                    max = array[i];
                }
                
            }
            Console.WriteLine("Min Value : " + min);
            Console.WriteLine("Max Value : " + max);
        }
        static void Main(string[] args) 
        {
            FindMinMaxOfArray arrd = new FindMinMaxOfArray();
            arrd.ReverseArray();
        
        }

    }
}
