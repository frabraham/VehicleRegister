
using VehicleRegister.model;

public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }


    public static Truck CreateTruck()
    {
        Truck truck = new Truck();
        VehicleService vehicleService = new VehicleService();
        VehicleService.CommonVehicleDetails(truck);

        Console.WriteLine("Lastekapasitet:  ");
        if (int.TryParse(Console.ReadLine(), out int loadCapacity))
        {
            truck.LoadCapacity = loadCapacity;
            return truck;
        }
        else
        {
            Console.WriteLine("Feil med volum i lastekapasitet. Lastebil er ikke lagt til.");
            return null;
        }
    }

}