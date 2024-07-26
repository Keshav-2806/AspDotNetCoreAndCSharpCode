using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CountDuplicateChar
{
    class CountDuplicateFromArray
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of Array");
            int arrayLength=Convert.ToInt32(Console.ReadLine());
            int[] array= new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Enter Element");
                int element=Convert.ToInt32(Console.ReadLine());
                array[i]=element;
            }
            Console.WriteLine("------------------------");
            var duplicateCount = array
                .GroupBy(x => x)
                .Where(g=>g.Count()>1)
                .Select(x => new {digit=x.Key,count=x.Count()});

            foreach (var item in duplicateCount)
            {
                Console.WriteLine($"digit:{item.digit},count:{item.count}");
            }
        }
    }
}
