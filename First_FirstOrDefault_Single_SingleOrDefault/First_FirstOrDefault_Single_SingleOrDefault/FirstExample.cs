using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_FirstOrDefault_Single_SingleOrDefault
{
    internal class FirstExample
    {
        public void FirstExample()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int methodSyntax = numbers.First();
            //Using Query Syntax
            int QuerySyntax = (from num in numbers
                               select num).First();
            //printing the value returned by the First Method
            Console.WriteLine(methodSyntax);
        }
        public void FirstWithPredicate()
        {
            //Fetching the first element from the data source which is divisible by 2
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int methodSyntax = numbers.First(num => num % 2 == 0);
            //Using Query Syntax
            int querySyntax = (from num in numbers
                               select num).First(num => num % 2 == 0);
            //Printing the value returned by the First Method
            Console.WriteLine(methodSyntax);
        }

        public void FirstWithNullDataSource()
        {
            List<int> numberEmpty = new List<int>() { };
            int methodSyntax = numberEmpty.First();
            Console.WriteLine(methodSyntax);
        }
        public void FirstWithCollectionNotReturningData()
        {
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            int methodSyntax = numbers.First(num => num > 50);
            Console.WriteLine(methodSyntax);
        }

        
    }

   
}
