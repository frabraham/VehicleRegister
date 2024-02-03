
using VehicleRegister.model;

public class Car : Vehicle
{
    public int Seats { get; set; }

    public static Car CreateCar()
    {
        Car car = new Car();
        VehicleService vehicleService = new VehicleService();
        VehicleService.CommonVehicleDetails(car);

        Console.WriteLine("Antall seter:  ");
        if (int.TryParse(Console.ReadLine(), out int seats))
        {
            car.Seats = seats;
            return car;
        }
        else
        {
            Console.WriteLine("Feil med antall seter. Bil er ikke lagt til.");
            return null;
        }
    }

}