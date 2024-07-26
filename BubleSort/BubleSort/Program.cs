namespace BubleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unOrderedNumbers = { 30, 10, -90, -40, 50, 25, 70, -54, -80, 30 };
            int nTemp = 0;
            for (int i = 0; i < unOrderedNumbers.Length; i++)
            {
                for (int j =i+1; j < unOrderedNumbers.Length; j++)
                {
                    if (unOrderedNumbers[i] > unOrderedNumbers[j])
                    {
                        nTemp = unOrderedNumbers[j];
                        unOrderedNumbers[j] = unOrderedNumbers[i];
                        unOrderedNumbers[i] = nTemp;

                    }
                }
                Console.WriteLine(unOrderedNumbers[i]);
            }
        }
    }
}