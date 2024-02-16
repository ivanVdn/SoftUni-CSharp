namespace _08.AnonymousThreat;

internal class Program
{
    private static void Main()
    {
        List<string> data = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string input;
        while ((input = Console.ReadLine()) != "3:1")
        {
            var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "merge":
                {
                    var leftIndex = Math.Max(0, int.Parse(tokens[1]));
                    var rightIndex = Math.Min(int.Parse(tokens[2]), data.Count - 1);

                    data = Merge(data, leftIndex, rightIndex);

                    break;
                }
                case "divide":
                {
                    var index = int.Parse(tokens[1]);
                    var partitions = int.Parse(tokens[2]);

                    Divide(data, index, partitions);
                    break;
                }
            }

        }

        Console.WriteLine(string.Join(" ", data));
    }

    private static List<string> Merge(List<string> data, int leftIndex, int rightIndex)
    {
        var merged = "";

        if (leftIndex < 0)
        {
            leftIndex = 0;
        }
        else if (leftIndex >= data.Count)
        {
            leftIndex = data.Count - 1;
        }

        if (rightIndex >= data.Count)
        {
            rightIndex = data.Count - 1;
        }
        else if (rightIndex < 0)
        {
            rightIndex = 0;
        }

        if (leftIndex >= data.Count || leftIndex == rightIndex)
        {
            return data;
        }

        for (int i = leftIndex; i <= rightIndex; i++)
        {
            merged += data[i];
        }

        data.RemoveRange(leftIndex, (rightIndex - leftIndex + 1));
        data.Insert(leftIndex, merged);

        return data;
    }

    private static List<string> Divide(List<string> list, int startIndex, int partitions)
    {
        if (startIndex > list.Count - 1 || startIndex < 0) return list;
        var divideLetters = list[startIndex];
        var partitionSize = divideLetters.Length / partitions;
        var partitionOutOfSize = divideLetters.Length % partitions;

        if (partitionOutOfSize == 0)
        {
            var letterToInsert = "";
            list.RemoveAt(startIndex);
            for (int i = 0; i < divideLetters.Length; i++)
            {
                if ((letterToInsert.Length == partitionSize) && (i % partitionSize == 0))
                {
                    list.Insert(startIndex++, letterToInsert);
                }

                if (i % partitionSize == 0)
                {
                    letterToInsert = "";
                }

                letterToInsert += divideLetters[i];
            }
            list.Insert(startIndex, letterToInsert);
        }
        else
        {
            var letterToInsert = "";
            list.RemoveAt(startIndex);
            for (int i = 0; i < divideLetters.Length; i++)
            {
                if ((letterToInsert.Length == partitionSize) && (i % partitionSize == 0))
                {
                    list.Insert(startIndex++, letterToInsert);
                }

                if (i % partitionSize == 0)
                {
                    letterToInsert = "";
                }

                letterToInsert += divideLetters[i];
            }
            if (letterToInsert.Length < partitionSize)
            {
                letterToInsert = list[startIndex - 1] + letterToInsert;
                list.RemoveAt(startIndex);
                list.Insert(startIndex - 1, letterToInsert);
            }
            list.Insert(startIndex, letterToInsert);
        }

        return list;
    }

}


/*
Ivo Johny Tony Bony Mony
merge 0 3
merge 3 4
merge 0 3
3:1

*/