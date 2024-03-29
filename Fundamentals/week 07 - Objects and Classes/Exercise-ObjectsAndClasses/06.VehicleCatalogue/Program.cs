using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading.Channels;

namespace _06.VehicleCatalogue
{

    internal class Vehicle
    {
        public string? Type { get; }
        public string? Model { get; }
        public string? Color { get; }
        public int HorsePower { get; }

        public Vehicle(string? type, string? model, string? color, string? horsePower)
        {
            //Type = type;
            Type = type switch
            {
                "car" => "Car",
                "truck" => "Truck",
                _ => Type
            };

            Model = model;
            Color = color;
            HorsePower = int.Parse(horsePower);
        }

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {HorsePower}";
        }
    }

    class Program
    {
        static void Main()
        {
            var catalogue = new List<Vehicle>();

            string? input;
            while ((input = Console.ReadLine()) != "End")
            {
                string?[]? cmd = input?
                    .Split()
                    .ToArray();
                var type = cmd?[0];
                var model = cmd?[1];
                var color = cmd?[2];
                var horsePower = cmd?[3];

                catalogue.Add(new Vehicle(type, model, color, horsePower));
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                var vehicleModel = input;

                var foundVehicle = catalogue.FirstOrDefault(v => v.Model == vehicleModel);

                if (foundVehicle != null)
                {
                    Console.WriteLine(foundVehicle);
                }
            }

            var averageHp = catalogue
                .Where(v => v.Type == "Car")
                .Select(v => v.HorsePower)
                .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHp:f2}.");

            averageHp = catalogue
                .Where(v => v.Type == "Truck")
                .Select(v => v.HorsePower)
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHp:f2}.");

        }
    }
}
//public class Vehicle
//{
//    public List<Car> Cars = new(); //{ get; set; }
//    public List<Truck> Trucks = new(); // { get; set; }
//}
//public class Car
//{
//    public Car(string type, string model, string color, int horsePower)
//    {
//        Type = type;
//        Model = model;
//        Color = color;
//        HorsePower = horsePower;
//    }

//    public string Type; //{ get; set; }
//    public string Model; // { get; set; }
//    public string Color; // { get; set; }
//    public int HorsePower; // {get; set; }
//}
//public class Truck
//{
//    public Truck(string type, string model, string color, int horsePower)
//    {
//        Type = type;
//        Model = model;
//        Color = color;
//        HorsePower = horsePower;
//    }

//    public string Type; //{ get; set; }
//    public string Model; // { get; set; }
//    public string Color; // { get; set; }
//    public int HorsePower; // {get; set; }
//}
//public class Program
//{
//    static void Main()
//    {
//        var vehicles = new Vehicle();
//        var listOfVehicles = new List<Vehicle>();
//        string? command;
//        while ((command = Console.ReadLine()) != "End")
//        {
//            var dataForVehicle = command?.Split().ToArray();


//            switch (dataForVehicle?[0])
//            {
//                case "car":
//                    vehicles.Cars.Add(new Car("Car", dataForVehicle[1], dataForVehicle[2], int.Parse(dataForVehicle[3])));
//                    break;
//                case "truck":
//                    vehicles.Trucks.Add(new Truck("Truck", dataForVehicle[1], dataForVehicle[2], int.Parse(dataForVehicle[3])));
//                    break;
//            }
//        }
//        var carsHp = 0.0;
//        var countCars = 0;
//        var truckHp = 0.0;
//        var countTrucks = 0;
//        string? input;
//        while ((input = Console.ReadLine()) != "Close the Catalogue")
//        {
//            var model = input;

//            foreach (var car in vehicles.Cars)
//            {
//                if (car.Model == model)
//                {
//                    Console.WriteLine($"Type: {car.Type}");
//                    Console.WriteLine($"Model: {car.Model}");
//                    Console.WriteLine($"Color: {car.Color}");
//                    Console.WriteLine($"Horsepower: {car.HorsePower}");
//                }
//                countCars++;
//                carsHp += car.HorsePower;
//            }

//            foreach (var truck in vehicles.Trucks)
//            {
//                if (truck.Model == model)
//                {
//                    Console.WriteLine($"Type: {truck.Type}");
//                    Console.WriteLine($"Model: {truck.Model}");
//                    Console.WriteLine($"Color: {truck.Color}");
//                    Console.WriteLine($"Horsepower: {truck.HorsePower}");
//                }
//                countTrucks++;
//                truckHp += truck.HorsePower;
//            }
//        }

//        if (vehicles.Cars.Any())
//        {
//            Console.WriteLine($"Cars have average horsepower of: {carsHp / countCars:f2}.");
//        }
//        else if (!vehicles.Cars.Any())
//        {
//            Console.WriteLine($"Cars have average horsepower of: 0.00.");
//        }

//        if (vehicles.Trucks.Any())
//        {
//            Console.WriteLine($"Trucks have average horsepower of: {truckHp / countTrucks:f2}.");
//        }
//        else if (!vehicles.Trucks.Any())
//        {
//            Console.WriteLine($"Trucks have average horsepower of: 0.00.");
//        }
//    }
//}

