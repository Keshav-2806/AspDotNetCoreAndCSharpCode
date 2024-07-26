namespace CodingQuestionAndAnswer
{
    internal class PrimeNumer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter maximum range for prime number:");
            int nMaxNumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime number between {0} and {1} are:", 2, nMaxNumber);
            bool isPrimeNumber = true;

            for (int i = 2; i <=nMaxNumber; i++)
            {
                for (int j = 2; j <= nMaxNumber; j++)
                {
                    if(i!=j && i%j==0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.WriteLine(i);
                }
              
                isPrimeNumber = true;
            }
        }
    }
}