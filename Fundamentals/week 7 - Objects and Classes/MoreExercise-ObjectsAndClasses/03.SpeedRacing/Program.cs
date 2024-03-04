namespace _03.SpeedRacing
{

    internal class Program
    {
        internal static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();

            for (var i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split().ToArray();
                var model = inputs[0];
                var fuelAmount = double.Parse(inputs[1]);
                var fuelForKm = double.Parse(inputs[2]);

                if (cars.ContainsKey(model)) return;
                cars.Add(model, new Car(model, fuelAmount, fuelForKm));
            }

            string? command;
            while ((command = Console.ReadLine()) != "End")
            {
                var parts = command?.Split().ToArray();
                var carModel = parts?[1];
                var amountOfKm = double.Parse(parts?[2]);
                var car = cars[carModel];

                if (car.CanDrive(amountOfKm))
                {
                    car.FuelAmount -= amountOfKm * car.FuelForKm;
                    car.TraveledDistance += amountOfKm;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }

        }
    }

    internal class Car
    {
        public string? Model { get; }
        public double FuelAmount { get; set; }
        public double FuelForKm { get; set; }
        public double TraveledDistance { get; set; }

        public Car(string? model, double fuelAmount, double fuelForKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelForKm = fuelForKm;
        }

        public bool CanDrive(double amountOfKm)
        {
            return FuelAmount >= amountOfKm * FuelForKm;
        }
    }
}
