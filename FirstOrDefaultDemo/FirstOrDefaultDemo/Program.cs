namespace FirstOrDefaultDemo
{
    public class Program
    {

        public void FirstOrDefaultExample() 
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int methodSyntax = numbers.FirstOrDefault();
            Console.WriteLine(methodSyntax);
            int querySyntax= (from num in numbers
                              select num).FirstOrDefault();
            Console.WriteLine(querySyntax);
        }

        public void FirstOrDefaultExample1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int methodSyntax = numbers.FirstOrDefault(num=>num%2==0);
            Console.WriteLine(methodSyntax);
            int querySyntax= (from num in numbers
                              select num).FirstOrDefault(num=> num%2==0);
            Console.WriteLine(querySyntax);
        }

        public void FirstOrDefaultExample2() 
        {
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            int methodSyntax = numbers.FirstOrDefault(num => num > 50);
            Console.WriteLine(methodSyntax);
            int querySyntax = (from num in numbers
                               select num).FirstOrDefault(num => num > 50);
            Console.WriteLine(querySyntax);
        }
        public void FirstOrDefaultExample3() 
        {
            List<int> numbers = new List<int>() { };
            int methodSyntax = numbers.FirstOrDefault();
            Console.WriteLine(methodSyntax);
            int querySyntax = (from num in numbers
                               select num).FirstOrDefault();
            Console.WriteLine(querySyntax);
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.FirstOrDefaultExample();
            p.FirstOrDefaultExample1();
            p.FirstOrDefaultExample2();
            p.FirstOrDefaultExample3();
        }
    }
}