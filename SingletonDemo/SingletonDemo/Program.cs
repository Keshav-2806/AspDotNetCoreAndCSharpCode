namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = MyClass.GetInstance();
            MyClass obj2 = MyClass.GetInstance();
        }
    }
}