namespace _04.RawData
{
    internal class Car
    {
        public string? Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Car(string? model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }
    }

    internal class Cargo
    {
        public int Weight { get; set; }
        public string? Type { get; set; }

        public Cargo(int weight, string? type)
        {
            Weight = weight;
            Type = type;
        }
    }

    internal class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }
    
    internal class Program
    {
        static void Main()
        {
            var cars = new List<Car>();

            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                string?[]? input = Console.ReadLine()?
                    .Split()
                    .ToArray();
                var model = input?[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var cargoWeight = int.Parse(input[3]);
                var cargoType = input?[4];

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                
                cars.Add(new Car(model, engine, cargo));
            }
            var command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                {
                    foreach (var car in cars.Where(car => car.Cargo.Type == "fragile" && car.Cargo.Weight < 1000))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
                }
                case "flamable":
                {
                    foreach (var car in cars.Where(car => car.Cargo.Type == "flamable" && car.Engine.Power > 250))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
                }
            }
        }
    }
}
