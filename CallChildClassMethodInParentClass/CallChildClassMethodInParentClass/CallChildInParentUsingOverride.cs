using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallChildClassMethodInParentClass
{
    class Parent1
    {
        public virtual void Display()
        {
            Console.WriteLine("Display method in parent1 class");
        }
    }
    class Child1 :Parent1 
    {
      public override void Display()
        {
            Console.WriteLine("Display method in child class");
        }
    }

    internal class CallChildInParentUsingOverride
    {
        static void Main(string[] args)
        {
            Parent1 parent = new Child1();
            parent.Display();
        }
    }
}
