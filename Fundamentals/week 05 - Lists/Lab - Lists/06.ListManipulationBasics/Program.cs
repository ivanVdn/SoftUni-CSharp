namespace _06.ListManipulationBasics
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
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int number = 0;
                int index = 0;
                switch (command[0])
                {
                    case "Add":
                        number = int.Parse(command[1]);
                        numberList.Add(number);
                        break;
                    case "Remove":
                        number = int.Parse(command[1]);
                        numberList.Remove(number);
                        break;
                    case "RemoveAt":
                        index = int.Parse(command[1]);
                        numberList.RemoveAt(index);
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);
                        numberList.Insert(index, number);
                        break;
                    case "end":
                        return;
                }
            }

            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
