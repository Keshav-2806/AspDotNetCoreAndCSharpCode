namespace ArrayReverse
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i <= arr.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.WriteLine(arr[j]);
                }
            }

        }
    }
}