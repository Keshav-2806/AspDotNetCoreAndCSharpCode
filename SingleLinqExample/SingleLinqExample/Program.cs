namespace SingleLinqExample
{
    public class Program
    {
     public void SingleExample()
        {
            List<int> numbers = new List<int>() { 10 };
            int numberMS = numbers.Single();
            Console.WriteLine(numberMS);
            int numberQS = (from num in numbers
                           select num).Single();
            Console.WriteLine(numberQS);
        }
        //public void SingleWithEmptyDataSource() 
        //{
        // List<int> numbers= new List<int>() { };
        //    int numberMS = numbers.Single();
        //    Console.WriteLine(numberMS);
        //    int numberQS = (from num in numbers
        //                    select num).Single();
        //    Console.WriteLine(numberQS);
        //}
        //public void SingleWithMoreThanOneElement()
        //{
        //    List<int> numbers = new List<int>() { 10, 20, 30 };
        //    int numberMS = numbers.Single();
        //    Console.WriteLine(numberMS);
        //    int numberQS = (from num in numbers
        //                    select num).Single();
        //    Console.WriteLine(numberQS);
        //}

        public void SingleWithPredicate()
        {
            List<int> numbers = new List<int> { 10, 20, 30 };
            int numberMS = numbers.Single(num=> num==20);
            Console.WriteLine(numberMS);
            int numberQS = (from num in numbers
                            select num).Single(num=>num==20);
            Console.WriteLine(numberQS);
        }
        
        public void SingleIfConditionReturnsMoreThanOneValue()
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };
            int numberMS = numbers.Single(num => num > 10);
            Console.WriteLine(numberMS);
            int numberQS = (from num in numbers
                            select num).Single(num=>num>10);
            Console.WriteLine(numberQS);

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SingleExample();
            //p.SingleWithEmptyDataSource();
           // p.SingleWithMoreThanOneElement();
            p.SingleWithPredicate();
            p.SingleIfConditionReturnsMoreThanOneValue();
        }
    }
    
}