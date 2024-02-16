namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var number = 0;
                switch (command[0])
                {
                    case "Delete":
                        number = int.Parse(command[1]);
                        numberList.RemoveAll(item => item == number);
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        var index = int.Parse(command[2]);
                        numberList.Insert(index, number);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}

