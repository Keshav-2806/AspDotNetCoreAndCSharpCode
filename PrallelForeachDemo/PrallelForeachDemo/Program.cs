namespace PrallelForeachDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = Enumerable.Range(1, 10).ToList();
            //foreach (int integer in integerList)
            //{
            //    Console.WriteLine(integer);
            //}
            Parallel.ForEach(integerList, i =>
            {
                Console.WriteLine(i);
            });
          //  Console.WriteLine(integerList);
        }
    }
}