using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ArrayReverseDemo
{
     class StringReverseDemo
    {
        static void Main()
        {
            Console.WriteLine("Enter String");
            string name=Console.ReadLine();

            //StringBuilder stringBuilder = new StringBuilder(name.Length);
            //for (int i = name.Length-1; i >=0; i--)
            //{
            //    stringBuilder.Append(name[i]);
            //}
            //Console.WriteLine(stringBuilder.ToString());

            char[] stringArray = name.ToCharArray();
            string reverse = String.Empty;
            for (int i = stringArray.Length-1; i >= 0; i--)
            {
                reverse = reverse + stringArray[i];

            }
            Console.WriteLine(reverse);

        }
    }
}
