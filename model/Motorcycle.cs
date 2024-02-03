using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegister.model;

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }


    public static Motorcycle CreateMotorcycle()
    {
        Motorcycle motorcycle = new Motorcycle();
        VehicleService vehicleService = new VehicleService();
        VehicleService.CommonVehicleDetails(motorcycle);

        Console.WriteLine("Sidevogn? (Ja/Nei): ");
        bool hasSidecar = Console.ReadLine().ToLower() == "ja";

        return motorcycle;

    }

}
