using ImplimentInterfacesWithSameMethod;

namespace ImplementInterfacesWithSameMethod
{
    
    public class Program:IShow1,IShow2
    {
        void IShow1.Show()
        {
            Console.WriteLine("This is First Interface..");
        }

        void IShow2.Show()
        {
            Console.WriteLine("This is Second Interface..");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
           ((IShow1) program).Show();
            ((IShow2)program).Show();

        }

    }
}