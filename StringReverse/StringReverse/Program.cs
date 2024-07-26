namespace StringReverse
{
    class Program
    {
        public static void StringReverse() 
        {
            Console.WriteLine("Please enter string which you want to reverse");
            string stringVar= Console.ReadLine();
            string revrseString = "";

            for (int i = stringVar.Length - 1; i >= 0; i--)
            {
              revrseString= revrseString+ stringVar[i];
            }
            Console.WriteLine("string is {0} and reverse string is {1} ", stringVar, revrseString);
        }
        static void Main(string[] args)
        {
            Program.StringReverse();
        }
    }
}