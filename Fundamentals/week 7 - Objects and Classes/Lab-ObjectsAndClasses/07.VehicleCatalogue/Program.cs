using System.Diagnostics;
using System.Xml.Linq;

namespace _07.VehicleCatalogue

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var trucks = new List<Truck>();

            string? command;
            while ((command = Console.ReadLine()) != "end")
            {

                var input = command?.Split("/").ToList();

                var type = input?[0];
                var brand = input?[1];
                var model = input?[2];
                var horsePower = int.Parse(input?[3] ?? string.Empty);
                var weight = horsePower;

                if (type == "Car")
                {
                    var car = new Car(type, brand, model, horsePower);
                    cars.Add(car);
                }
                else
                {
                    var truck = new Truck(type, brand, model, weight);
                    trucks.Add(truck);
                }
            }

            for (var i = 0; i < cars.Count; i++)
            {
                var car = cars[i];
                if (car.Type == "Car" && i == 0)
                {
                    Console.WriteLine("Cars:");
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                else if (car.Type == "Car" && i != 0)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            for (var i = 0; i < trucks.Count; i++)
            {
                var truck = trucks[i];
                if (truck.Type == "Trucks" && i == 0)
                {
                    Console.WriteLine("Truck:");
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
                else if (truck.Type == "Truck" && i != 0)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    public class VehicleCatalog
    {
        public VehicleCatalog(List<Car> cars, List<Truck> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    public class Car
    {
        public Car(string? type, string? brand, string? model, int horsePower)
        {
            Type = type;
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Truck
    {
        public Truck(string? type, string? brand, string? model, int weight)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
}
