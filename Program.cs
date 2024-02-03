using VehicleRegister.model;

var vehicleService = new VehicleService();

while (true)
{
    Console.WriteLine("1. Legg til bil!");
    Console.WriteLine("2. Legg til lastebil!");
    Console.WriteLine("3. Legg til motorsykkel!");
    Console.WriteLine("4. Legg til båt!");
    Console.WriteLine("5. Vis alle kjøretøy!");
    Console.WriteLine("6. Avslutt!");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            vehicleService.Add(Car.CreateCar());
            break;
        case "2":
            vehicleService.Add(Truck.CreateTruck());
            break;
        case "3":
            vehicleService.Add(Motorcycle.CreateMotorcycle());
            break;
        case "4":
            vehicleService.Add(Boat.CreateBoat());
            break;
        case "5":
            vehicleService.ShowVehicles();
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Ugyldig valg, prøv igjen!");
            break;
    }
}
