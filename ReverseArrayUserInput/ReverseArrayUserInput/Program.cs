namespace ReverseArrayUserInput
{
     class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("How many number of items");
            int num=Convert.ToInt32(Console.ReadLine());
            int[] numbers= new int[num];
            for (int i = 0; i < num; i++) 
            {
                Console.WriteLine("Enter Data");
                int data= Convert.ToInt32(Console.ReadLine());
                numbers[i]= data;
            }
            //Array.Reverse(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            int [] reverseArray= new int[numbers.Length];
            for (int i=reverseArray.Length-1; i>=0; i--)
            {
                reverseArray[numbers.Length-i-1]= numbers[i];

            }
            Console.WriteLine("Your data is: " + String.Join(", ", numbers));
            Console.WriteLine("Reverse Array is : " + String.Join(", ", reverseArray));


        }
    }
}