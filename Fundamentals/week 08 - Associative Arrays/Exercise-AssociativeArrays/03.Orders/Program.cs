using System.Net.Http.Headers;

namespace _03.Orders
{
    internal class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string? name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Print()
        {
            return $"{Name} -> {Price * Quantity:f2}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            var products = new List<Product>();
            string? command;
            while ((command = Console.ReadLine()) != "buy")
            {
                var cmd = command?.Split().ToList();
                var name = cmd?[0];
                var price = decimal.Parse(cmd[1]);
                var quantity = int.Parse(cmd[2]);

                var product = new Product(name, price, quantity);

                if (products.All(p => p.Name != product.Name))
                {
                    products.Add(product);
                }
                else
                {
                    foreach (var p in products.Where(p => p.Name == name))
                    {
                        p.Price = price;
                        p.Quantity += quantity;
                    }
                }
            }

            foreach (var p in products)
            {
                Console.WriteLine(p.Print());
            }
        }
    }

}
