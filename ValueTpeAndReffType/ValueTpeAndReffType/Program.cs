namespace ValueTpeAndReffType
{
    struct Employee
    {
        public int Salary;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Salary = 5000;
            e.Age = 23;

            Employee e1 = e;
            Employee e2 = e;

            e.Age = 25;
            Console.WriteLine(e1.Age);
            Console.WriteLine(e2.Age);
            Console.WriteLine(e.Age);
            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }
    }
}