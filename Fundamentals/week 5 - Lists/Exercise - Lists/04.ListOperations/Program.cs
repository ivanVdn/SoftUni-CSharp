using System.Runtime.ExceptionServices;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var number = 0;
                var index = 0;
                switch (command[0])
                {
                    case "Add":
                        number = int.Parse(command[1]);
                        numberList.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(command[1]);
                        index = int.Parse(command[2]);

                        if (IsNotValidIndex(index, numberList.Count - 1))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numberList.Insert(index, number);
                        break;
                    case "Remove":
                        index = int.Parse(command[1]);
                        var lastIndex = numberList.Count - 1;

                        if (IsNotValidIndex(index, lastIndex))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numberList.RemoveAt(index);
                        break;
                    case "Shift":
                        var direction = command[1];
                        var count = int.Parse(command[2]);
                        numberList = Shift(numberList, direction, count);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numberList));
        }

        static List<int> Shift(List<int> numberList, string direction, int count)
        {
            count %= numberList.Count;
            switch (direction)
            {
                case "left":
                {
                    var shiftedPartOfList = numberList.GetRange(0, count);
                    numberList.RemoveRange(0, count);
                    numberList.InsertRange(numberList.Count, shiftedPartOfList);
                }
                    break;
                case "right":
                {
                    var shiftedPartOfList = numberList.GetRange(numberList.Count - count, count);
                    numberList.RemoveRange(numberList.Count - count, count);
                    numberList.InsertRange(0, shiftedPartOfList);
                }
                    break;
            }

            return numberList;
        }

            //var first = 0;
            //var last = 0;
            //switch (direction)
            //{
            //    case "left":
            //        for (int i = 0; i < count; i++)
            //        {
            //            first = numberList[i];
            //            numberList.RemoveAt(i);
            //            numberList.Add(first);
            //            i = -1;
            //        }
            //        Console.WriteLine(string.Join(", ", numberList));
            //        break;
            //    case "right":

            //        break;
            //}
        //}

        private static bool IsNotValidIndex(int index, int lastIndex)
        {
            return index < 0 || index > lastIndex;
        }
    }
}

