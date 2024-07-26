namespace primeNumber
{
    class Program
    {
        public void PrimeNumber() 
        {
            Console.WriteLine("Range for prime number: ");
            int nMaxRange = Convert.ToInt32(Console.ReadLine());

            bool isPrimeNumer = true;
            for (int i = 2; i <= nMaxRange; i++)
            {
                for (int j = 2; j <= nMaxRange; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrimeNumer = false;
                        break;
                    }
                }
                if (isPrimeNumer)
                {
                    Console.WriteLine(i);
                }

                isPrimeNumer = true;
            }

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.PrimeNumber();
        }
    }
}