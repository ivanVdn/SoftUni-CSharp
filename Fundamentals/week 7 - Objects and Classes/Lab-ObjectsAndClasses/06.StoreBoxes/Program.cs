using System.Xml.Schema;

namespace _06.StoreBoxes
{
    public class Item
    {
        public Item(string? name, decimal itemPrice)
        {
            Name = name;
            Price = itemPrice;
        }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Box
    {
        public Box(string? serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }
        public string? SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice => ItemQuantity * Item.Price;
    }
    internal class Program
    {
        private static void Main()
        {
            var boxes = new List<Box>();

            string? command;
            while ((command = Console.ReadLine()) != "end")
            {
                var itemsInput = command?
                    .Split(" ")
                    .ToList();
                var serialNumber = itemsInput?[0];
                var name = itemsInput?[1];
                var quantity = int.Parse(itemsInput?[2] ?? string.Empty);
                var price = decimal.Parse(itemsInput?[3] ?? string.Empty);

                var item = new Item(name, price);
                var box = new Box(serialNumber, item, quantity);

                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(x => x.BoxPrice).ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }

        }
    }
}

/*
19861519 Dove 15 2.50
86757035 Butter 7 3.20
39393891 Orbit 16 1.60
37741865 Samsung 10 1000
end
*/