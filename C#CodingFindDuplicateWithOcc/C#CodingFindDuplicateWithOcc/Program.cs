namespace C_CodingFindDuplicateWithOcc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Element");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
             var dict = new Dictionary<int, int>();
            foreach (var i in array)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict[i] = 1;
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine("Value {0} occurred {1} times",pair.Key,pair.Value);
            }
        }
    }
}