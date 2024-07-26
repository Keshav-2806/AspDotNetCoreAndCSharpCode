using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ArrayWithObjectModifire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrLst = new ArrayList(3);

            arrLst.Add(1);
            arrLst.Add("Keshav");
            arrLst.Add(2);
            arrLst.Add(3);
            arrLst.Add("Kii");
            //arrLst.Add(true);
            //arrLst.Add(true);
            //arrLst.Add(true);
            //arrLst.Add(true);
            Console.WriteLine(arrLst.Capacity);

            foreach (object i in arrLst) 
            {
                Console.WriteLine(i);
            }



            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //int sum = 0;

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //    sum=sum+i;
            //    Console.WriteLine(sum);
            //}



            //object[] arr1= new object[3];
            //arr1[0] = 1;
            //arr1[1] = "hello";
            //arr1[2] = true;
            //int sum1 = 0 ;
            //int a = (int)arr1[0];

            //foreach(object i in arr1)
            //{
            //    Console.WriteLine(i);
            //    //sum1 = sum1 + i;
            //    sum1 = sum1 +a;
            //}
        }
    }
}