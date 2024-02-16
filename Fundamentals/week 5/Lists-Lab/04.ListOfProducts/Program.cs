namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productList = new List<string>();
            int number = int.Parse(Console.ReadLine());
            int n = number;
            while (n > 0)
            {
                n--;
                productList.Add(Console.ReadLine());
            }

            productList.Sort();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i+1}.{productList[i]}");
            }
        }
    }
}
