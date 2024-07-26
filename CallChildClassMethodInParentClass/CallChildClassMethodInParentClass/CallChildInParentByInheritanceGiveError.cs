using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallChildClassMethodInParentClass
{
    class Parent2
    {
        public void Display()
        {
            Console.WriteLine("Call Display in Parent class");
        }
    }
    class Child2:Parent2
    {
        public void Show()
        {
            Console.WriteLine("Call show in Child class");
        }
    }
    internal class CallChildInParentByInheritanceGiveError
    {
        static void Main(string[] args)
        {
            Parent2 parent2 = new Child2();
            parent2.Display();
            //parent2.Show();
        }
    }
}
