// See https://aka.ms/new-console-template for more information
class Program
{
    public void func1()
    {
        Console.WriteLine("This is first function..");
    }
    public void func2()
    {
        Console.WriteLine("This is second function..");
    }
    static void Main(string[] args)
    {
        Program p = new Program();
        p.func1();
        p.func2();

    }
}