namespace FactoryDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Vehicle Type");
            string userInput = Console.ReadLine();//bike//car

            IVehicle Type = VehicleFactory.GetVehicle(userInput);

            Console.WriteLine("Vehicle Type is : " + Type.VehicleType());
            Console.WriteLine("Number of Wheels : "+ Type.NumberOfWheels());

            Console.ReadLine();
        }
    }
}