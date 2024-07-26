namespace CountDuplicateChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str= Console.ReadLine();

            var duplicateChar = str
                .Where(c => !char.IsWhiteSpace(c))
                .GroupBy(c => c)
                .Where(g => g.Count() > 1)
                .Select(g => new { Char = g.Key, Count = g.Count() });

            
            Console.WriteLine("Duplicate char");
            foreach (var group in duplicateChar)
            {
                Console.WriteLine($"Character:{group.Char},Count:{group.Count}");
            }
        }
    }
}