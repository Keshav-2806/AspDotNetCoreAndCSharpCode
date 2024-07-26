namespace MultipleCatchBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);

                string f = null;
                Console.WriteLine(f.Length);

                int[] arr = new int[3];
                arr[0] = 11;
                arr[1] = 12;
                arr[2] = 13;
                arr[3] = 14;
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
           
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}