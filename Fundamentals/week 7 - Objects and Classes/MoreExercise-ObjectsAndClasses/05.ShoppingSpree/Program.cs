using System.Data.SqlTypes;
using System.Diagnostics.Contracts;

namespace _05.ShoppingSpree
{
    class Person
    {
        public string Name { get; }
        public double Money { get; set; }
        public List<Product> Bag { get; }

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Bag = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if (Money >= product.Cost)
            {
                Bag.Add(product);
                Money -= product.Cost;
                Console.WriteLine($"{Name} bought {product}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            if (Bag.Count > 0)
            {
                return $"{Name} - {string.Join(", ", Bag)}";
            }
            else
            {
                return $"{Name} - Nothing bought";
            }
        }
    }


    class Product
    {
        public string Name { get; }
        public double Cost { get; }

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    internal class Program
    {
        internal static void Main()
        {
            var peopleData = Console.ReadLine().Split(';').ToArray();
            var productsData = Console.ReadLine().Split(';').ToArray();

            var people = new Dictionary<string, Person>();
            foreach (var personInfo in peopleData)
            {
                var personDetails = personInfo.Split('=').ToArray();
                var name = personDetails[0];
                var money = double.Parse(personDetails[1]);
                people[name] = new Person(name, money);
            }

            var products = new Dictionary<string, Product>();
            foreach (var productInfo in productsData)
            {
                var productDetails = productInfo?
                    .TrimEnd()
                    .Split('=',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var name = productDetails[0];
                var cost = double.Parse(productDetails[1]);

                products[name] = new Product(name, cost);
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                var tokens = command.Split(' ').ToArray();
                var personName = tokens[0];
                var productName = tokens[1];

                if (people.ContainsKey(personName) && products.ContainsKey(productName))
                {
                    people[personName].BuyProduct(products[productName]);

                }

            }

            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }
        }
    }
}
