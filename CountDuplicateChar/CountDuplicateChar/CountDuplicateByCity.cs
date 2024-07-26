using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDuplicateChar
{
    internal class CountDuplicateByCity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of array");
            int strLength= Convert.ToInt32(Console.ReadLine());
            string[] strArray = new string[strLength];
            for (int i = 0; i < strLength; i++)
            {
                Console.WriteLine("Enter City Name");
                string CityName = Console.ReadLine();
                strArray[i] = CityName;
            }

            var duplicateCity = strArray
                .GroupBy(c => c)
               // .Where(c => c.Count()>0)
                .Where(c => c.Contains("Patna"))
                .Select(g => new { City = g.Key, Count = g.Count() });

            foreach (var item in duplicateCity)
            {
                Console.WriteLine($"City:{item.City}, Count: {item.Count}");
            }
        }
    }
}
