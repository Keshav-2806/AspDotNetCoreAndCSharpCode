using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseDemo
{
     class ArrayReverseSecondMethod
    {
        public static void ReverseArrayDemo()
        {
            Console.WriteLine("Enter Length of Array1");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Enter Element");
                int element = Convert.ToInt32(Console.ReadLine());
                array1[i]=element;
            }
            List<int> arrayList = new List<int>();
            for (int i = arrayLength;i > 0; i--)
            {
                arrayList.Add(i);
            }


            int[] array2 = arrayList.ToArray();
            Console.WriteLine("---------------");
            foreach (var item in array2)
            {

                Console.WriteLine(item);
            }
        }
        static void Main(string[] args) 
        {
            ArrayReverseSecondMethod.ReverseArrayDemo();
        
        }
    }
}
