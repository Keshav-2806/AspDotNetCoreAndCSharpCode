namespace CountOccuranceOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String which you want to give");
            string CountOcc= Console.ReadLine();

            Dictionary<char, int> dct = new Dictionary<char, int>();

            foreach (char item in CountOcc)
            {
                if (dct.ContainsKey(item))
                {
                    dct[item]++;
                }
                else
                {
                    dct[item] = 1;
                }

            }
            Console.WriteLine("Char Count");
            foreach (var item in dct)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}