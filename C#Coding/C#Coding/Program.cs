// See https://aka.ms/new-console-template for more information
namespace CSharpCoding
    {
    class program 
    {
        
        static void main(String[] args) 
        {
Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter desired max number to display prime numbers");
int nMaxNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Prime number between {0} and {1} :", 2, nMaxNumber);

bool IsPrimeNumber = true;
for (int i = 2; i <= nMaxNumber; i++)
{
    for (int j = 2; j <= nMaxNumber; j++)
    {
        if (i != j && i % j == 0)
        {
            IsPrimeNumber = false;
            break;
        }
    }
    if (IsPrimeNumber)
    {
        Console.WriteLine(i);
    }
    IsPrimeNumber = true;
}

      }  
    }
        }