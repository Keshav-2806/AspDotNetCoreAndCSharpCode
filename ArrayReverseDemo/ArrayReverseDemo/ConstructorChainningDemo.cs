using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseDemo
{
     class ConstructorChainningDemo
    {
        public ConstructorChainningDemo(): this(10)
        {
            
            Console.WriteLine("First Constructor is calling");


        }
        public ConstructorChainningDemo(int Age)
        {
            Console.WriteLine("Second Constructor is Calling and age is "+Age);
        }

        static void Main()
        {
            ConstructorChainningDemo constructorChainningDemo = new ConstructorChainningDemo();
        }

    }
}
