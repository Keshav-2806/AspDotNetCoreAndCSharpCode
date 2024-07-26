using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseDemo
{
    class ArraySort1
    {
        public void ArraySort2()
        {
            Console.WriteLine("Enter length of array23");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("enter element");
                int element = Convert.ToInt32(Console.ReadLine());
                arr[i] = element;
            }
            int temp;
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i; j < arrayLength; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            Console.WriteLine(arr[arrayLength - 2]);


        }
        static void Main(string[] args)
        {
            
           ArraySort1 arraySort1 = new ArraySort1();
            arraySort1.ArraySort2();
             
        }
    }
}
