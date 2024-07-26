namespace C_DesignPattern
{
    internal class TestLogger
    {
        class Test
        {

        }
        static void Main(string[] args)
        {
            //Singleton
            // Logger obj1 = new Logger();
            //Logger obj2 = new Logger();
            Console.WriteLine("--Singleton--");
            Logger obj1 = Logger.GetInstance();
            Logger obj2 = Logger.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            //Non Singleton
            Console.WriteLine("--Non Singleton--");
            Test obj3= new Test();
            Test obj4= new Test();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());
        }
    }
}