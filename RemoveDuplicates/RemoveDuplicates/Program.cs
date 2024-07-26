//namespace RemoveDuplicates
//{

//    class Program
//    {
//        static void array1(int[] array)
//        {
//            foreach (int i in array)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            int[] array = { 1, 1, 1, 1, 1, 1, 2, 2, 3, 3,4,4 };
//            HashSet<int> set = new HashSet<int>();
//            List<int> list = new List<int>();
//            foreach (int i in array)
//            {
//                if (!set.Contains(i))
//                {
//                    set.Add(i);
//                    list.Add(i);
//                }
//            }

//            int[] aaaa = set.ToArray();
//            Program.array1(aaaa);
//            Console.WriteLine(aaaa);

//        }
//    }
//}

namespace RemoveDuplicates
{
    class RemoveDuplicate
    {
        public static void arr1(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
           // List<int> list = new List<int>();
            foreach (int i in arr)
            {
                if (!set.Contains(i))
                {
                    set.Add(i);
            //        list.Add(i);
                }
            }
            foreach(int i in set)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 2, 3 };
            RemoveDuplicate.arr1(arr);

        }
    }
}


