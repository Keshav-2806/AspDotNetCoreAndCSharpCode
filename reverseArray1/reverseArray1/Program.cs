namespace reverseArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] reverseArr = new int[arr.Length];

           
                for (int j = arr.Length-1; j >= 0; j--)
                {
                reverseArr[arr.Length-j-1] = arr[j];
                }
            Console.WriteLine("Original array: " + String.Join(" ",arr));
            Console.WriteLine("New Array " + String.Join(" ",reverseArr));
        }
        
    }
}