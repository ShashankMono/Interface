using InterfaceUse.Models;

namespace InterfaceUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles =
            {
                new Bike(200,"Bajaj Pulsar NS200","Pulsar"),
                new Scooter(125,"Active 125","Honda Activa"),
                new Car(1950,"Mercedes-Benz E-Class","Mercedes"),
                new Truck(3869,"Volvo D39","Volvo")
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"===================================\n" +
                    $"{vehicle.EngineCC()}\n" +
                    $"{vehicle.BuildByCompany()}\n" +
                    $"{vehicle.ModelNameOfVehicle()}\n");
            }
        }
    }
}
