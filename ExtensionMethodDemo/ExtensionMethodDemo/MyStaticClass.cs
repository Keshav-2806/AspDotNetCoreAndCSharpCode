using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    static class MyStaticClass
    {
        public static void func3(this Program p)
        {
            Console.WriteLine("This is  third function ");
        } 
    }
}
