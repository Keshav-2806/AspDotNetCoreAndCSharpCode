namespace CallChildClassMethodInParentClass
{
    interface IShow
    {
        void Show();
    }
    class Parent
    {
        public void Display()
        {
          //  show.Show();
            Child child1= new Child();
            child1.Show();
        }
    }

    class Child : Parent, IShow
    {
        public void Show()
        {
            Console.WriteLine("Show method call in child class");
        }
    }
    internal class CallChildInParentUsingInterface
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();
            parent.Display();
        }
    }
}