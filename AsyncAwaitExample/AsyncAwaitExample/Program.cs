namespace AsyncAwaitExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //int i = 10;
            //int j = 10;
            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));

            string s = "Hello";
            string s1 = "Hello";
            string s2 = "hello";

            Console.WriteLine(s==s1);
            Console.WriteLine(s.Equals(s1));
        }
    }
}