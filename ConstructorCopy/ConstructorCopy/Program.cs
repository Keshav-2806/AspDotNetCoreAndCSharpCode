namespace ConstructorCopy
{
   public  class Program
    {
        string name;
        public Program(string name1)
        {
            name = name1; 
        }
        //copy constructor
        public Program(Program p)
        {
            name = p.name;    
        }
        static void Main(string[] args)
        {
            Program p1 = new Program("Keshav");
            Console.WriteLine("Name of p1 :"+p1.name);
            //copy constructor
            Program p2 = new Program(p1);
            Console.WriteLine("Name of p2 :"+p2.name);
        }
    }
}