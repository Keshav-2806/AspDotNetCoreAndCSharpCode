namespace SingleTonPractice1
{
    sealed class Program
    {
        private Program()
        {               
        }
        private static Program instance;
        private static object instanceLock = new object();

        public static Program GetInstance()
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new Program();
                    }
                }
            }
            return instance;
        }



        static void Main(string[] args)
        {
            Program p = Program.GetInstance();
        }
    }
}