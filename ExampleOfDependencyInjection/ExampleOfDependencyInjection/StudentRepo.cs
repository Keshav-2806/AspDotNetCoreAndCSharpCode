namespace ExampleOfDependencyInjection
{
    public class StudentRepo : IStudentRepo
    {
        public string PrintStudentName()
        {
            return "Keshav";
        }
    }
}
