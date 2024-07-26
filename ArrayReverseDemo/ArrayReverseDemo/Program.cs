// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ArrayReverseDemo;
using System.Threading.Channels;

class ArrayReverse
{
    public void ReverseArrayMethod()
    {
        Console.WriteLine("Enter Length of Array");
        int arrLength = Convert.ToInt32(Console.ReadLine());
        int[] arr= new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            Console.WriteLine("Enter Element");
            int element = Convert.ToInt32(Console.ReadLine());
            arr[i]=element;
        }
        int[] reverseArr=new int[arrLength];
        for(int i = 0;i < arrLength; i++)
        {
            reverseArr[i] = arr[arrLength - i - 1];

        }
        foreach(int i in reverseArr)
        {
            Console.WriteLine(i);
        }
    }
    static void Main(string[] args)
    {
        ArrayReverse ar= new ArrayReverse();
        ar.ReverseArrayMethod();
        

    }
}