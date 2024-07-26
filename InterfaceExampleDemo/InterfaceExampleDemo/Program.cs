namespace InterfaceExampleDemo
{
    interface InterfaceMethod1
    {
        void Method();
    }
    interface InterfaceMethod2
    {
        void Method();
    }
    internal class Program:InterfaceMethod1, InterfaceMethod2
    {
        void InterfaceMethod1.Method()
        {
            Console.WriteLine("This is Interface Method 1..");
        }
        void InterfaceMethod2.Method()
        {
            Console.WriteLine("This is Interface method 2..");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ((InterfaceMethod1)p).Method();
            ((InterfaceMethod2)p).Method();
        }
    }
}