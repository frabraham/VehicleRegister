

using System.Reflection;
using VehicleRegister.model;

public class VehicleService
{
    List<Vehicle> vehicles = new List<Vehicle>();

    public void Add(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }


    public static void CommonVehicleDetails(Vehicle vehicle)
    {
        Console.WriteLine("Skiltnummer: ");
        string plateNumber = Console.ReadLine();

        Console.WriteLine("Merke: ");
        string brand = Console.ReadLine();

        Console.WriteLine("Modell: ");
        string model = Console.ReadLine();

        Console.WriteLine("Årsmodell: ");
        if (int.TryParse(Console.ReadLine(), out int yearModel))
        {
            vehicle.YearModel = yearModel;
        }
        else
        {
            Console.WriteLine("Ugyldig årsmodel. Kjøretøy ble ikke lagt til.");
            
        }
    }


    /*********************************************************************/

    public void ShowVehicles()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("Det er ingen kjøretøy i registeret.");
            return;
        }

        Console.WriteLine("Liste av kjøretøy:");
        Console.WriteLine("---------------------------------------------");

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine($"Skiltnummer: {vehicle.PlateNumber}, Merke: {vehicle.Brand}, Model: {vehicle.Model}, Årsmodel: {vehicle.YearModel}");

            if (vehicle is Car)
            {
                Console.WriteLine($"Antall seter: {(vehicle as Car).Seats}");
            }
            else if (vehicle is Truck)
            {
                Console.WriteLine($"Lastekapasitet: {(vehicle as Truck).LoadCapacity}");
            }
            else if (vehicle is Motorcycle)
            {
                Console.WriteLine($"Har sidevogn: {(vehicle as Motorcycle).HasSidecar}");
            }
            else if (vehicle is Boat)
            {
                Console.WriteLine($"Lengde: {(vehicle as Boat).BoatLength} meters, Bredde: {(vehicle as Boat).BoatWidth} meters, Hestekrefter: {(vehicle as Boat).BoatHorsepower}");
            }

            Console.WriteLine();
        }
    }
}