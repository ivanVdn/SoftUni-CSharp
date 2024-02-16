namespace _07.ListManipulationAdvanced;

internal class Program
{
    private static void Main()
    {
        var numberList = Console.ReadLine()?
            .Split()
            .Select(int.Parse)
            .ToList();
        var isEdited = false;
        string? input;
        while ((input = Console.ReadLine()) != "end")
        {
            var command = input?.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (numberList != null)
            {
                switch (command?[0])
                {
                    case "Add":
                        numberList?.Add(int.Parse(command[1]));
                        isEdited = true;
                        break;
                    case "Remove":
                        numberList?.Remove(int.Parse(command[1]));
                        isEdited = true;
                        break;
                    case "RemoveAt":
                        numberList?.RemoveAt(int.Parse(command[1]));
                        isEdited = true;
                        break;
                    case "Insert":
                        numberList?.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isEdited = true;
                        break;
                    case "Contains":
                        var number = int.Parse(command[1]);
                        var isInList = numberList != null && numberList.Contains(number);
                        Console.WriteLine(isInList ? "Yes" : "No such number");
                        break;
                    case "GetSum":
                        Console.WriteLine(numberList.Sum());
                        break;
                    case "PrintEven":
                        var evenNumbersList = numberList.Where(item => item % 2 == 0).ToList();
                        Console.WriteLine(string.Join(" ", evenNumbersList));
                        break;
                    case "PrintOdd":
                        var oddNumbersList = numberList.Where(item => item % 2 != 0).ToList();
                        Console.WriteLine(string.Join(" ", oddNumbersList));
                        break;
                    case "Filter":
                        List<int> filteredList = new();
                        switch (command[1])
                        {
                            case "<":
                                filteredList.AddRange(numberList.Where(item => item < int.Parse(command[2])));
                                break;
                            case ">":
                                filteredList.AddRange(numberList.Where(item => item > int.Parse(command[2])));
                                break;
                            case "<=":
                                filteredList.AddRange(numberList.Where(item => item <= int.Parse(command[2])));
                                break;
                            case ">=":
                                filteredList.AddRange(numberList.Where(item => item >= int.Parse(command[2])));
                                break;
                        }
                        Console.WriteLine(string.Join(" ", filteredList));
                        break;
                }
            }
        }
        if (isEdited == true && numberList != null)
        {
            Console.WriteLine(string.Join(" ", numberList));
        }
        
    }
}