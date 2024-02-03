using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegister.model;

public class Boat : Vehicle
{
    public int BoatLength { get; set; }
    public int BoatWidth { get; set; }
    public int BoatHorsepower { get; set; }

    public static Boat CreateBoat()
    {
        Boat boat = new Boat();
        VehicleService vehicleService = new VehicleService();
        VehicleService.CommonVehicleDetails(boat);

        Console.WriteLine("Lengde:  ");
        if (int.TryParse(Console.ReadLine(), out int boatLength))
        {
            boat.BoatLength = boatLength;
        }
        else
        {
            Console.WriteLine("Ugyldig lengde. Båt ble ikke lagt til.");
            return null;
        }

        Console.WriteLine("Bredde:  ");
        if (int.TryParse(Console.ReadLine(), out int boatWidth))
        {
            boat.BoatWidth = boatWidth;
        }
        else
        {
            Console.WriteLine("Ugyldig bredde. Båt ble ikke lagt til.");
            return null;
        }
        Console.WriteLine("Hestekrefter:  ");
        if (int.TryParse(Console.ReadLine(), out int boatHorsepower))
        {
            boat.BoatHorsepower = boatHorsepower;
            return boat;
        }
        else
        {
            Console.WriteLine("Ugyldig hestekrefter. Båt ble ikke lagt til.");
            return null;
        }
    }
}
