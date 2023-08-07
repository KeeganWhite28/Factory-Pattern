namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to make? Car or Motorcycle?");
            string userInput = Console.ReadLine();

           VehicleFactory factory = new VehicleFactory();
     IVehicle myVehilce = factory.CreateVehicle(userInput);

            myVehilce.Drive();
            Console.WriteLine("Lets make another vehicle.");

            userInput = Console.ReadLine();

            
        }
    }
}
