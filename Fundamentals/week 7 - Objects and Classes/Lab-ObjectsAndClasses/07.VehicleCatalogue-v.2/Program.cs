namespace _07.VehicleCatalogue_v._2
{
    public class Car
    {
        public string? Brand { get; }
        public string? Model { get; }
        public int HorsePower { get; }

        public Car(string? brand, string? model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
    }
    public class Truck
    {
        public string? Brand { get; }
        public string? Model { get; }
        public int Weight { get; }

        public Truck(string? brand, string? model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
    public class VehicleCatalog
    {
        public List<Car> Cars { get; } = new List<Car>();
        public List<Truck> Trucks { get; } = new List<Truck>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void AddTruck(Truck truck)
        {
            Trucks.Add(truck);
        }
    }
    internal class Program
    {
        private static void Main()
        {
            var vehicles = new VehicleCatalog();

            string? command;
            while ((command = Console.ReadLine()) != "end")
            {
                var input = command?.Split("/").ToList();

                var type = input?[0];
                var brand = input?[1];
                var model = input?[2];
                var horsePowerOrWeight = int.Parse(input?[3] ?? string.Empty);

                switch (type)
                {
                    case "Car":
                        vehicles.AddCar(new Car(brand, model, horsePowerOrWeight));
                        break;
                    case "Truck":
                        vehicles.AddTruck(new Truck(brand, model, horsePowerOrWeight));
                        break;
                }
            }

            if (vehicles.Cars.Any())
            {
                Console.WriteLine("Cars:");
                foreach (var car in vehicles.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehicles.Trucks.Any())
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in vehicles.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

}


