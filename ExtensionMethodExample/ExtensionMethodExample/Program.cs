namespace ExtensionMethodExample
{
    class Program
    {
        public void Func1() 
        {
            Console.WriteLine("This is first function");
        }
        public void Func2()
        {
            Console.WriteLine("This is second function");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Func1();
            p.Func2();
        }
    }
}