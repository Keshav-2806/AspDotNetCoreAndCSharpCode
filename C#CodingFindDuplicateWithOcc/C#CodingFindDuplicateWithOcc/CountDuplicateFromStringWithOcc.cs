using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CodingFindDuplicateWithOcc
{
    internal class CountDuplicateFromStringWithOcc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            String string1=Console.ReadLine();

            Dictionary<char,int> dict = new Dictionary<char,int>();

            foreach (char c in string1.Replace(" ",string.Empty)) 
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] = dict[c]+1;
                }
                else
                {
                    dict[c] = 1;
                }
            } 
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }
        }
    }
}
