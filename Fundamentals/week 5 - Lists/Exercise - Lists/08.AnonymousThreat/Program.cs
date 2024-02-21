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
                        var leftIndex = Math.Clamp(int.Parse(tokens[1]), 0, data.Count - 1);
                        var rightIndex = Math.Clamp(int.Parse(tokens[2]), 0, data.Count - 1);

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

        if (leftIndex == rightIndex)
        {
            return data;
        }

        for (var i = leftIndex; i <= rightIndex; i++)
        {
            merged += data[i];
        }

        data.RemoveRange(leftIndex, (rightIndex - leftIndex + 1));
        data.Insert(leftIndex, merged);

        return data;
    }

    private static List<string> Divide(List<string> data, int startIndex, int partitions)
    {
        if (startIndex > data.Count - 1 || startIndex < 0) return data;//
        var divideLetters = data[startIndex];
        var partitionSize = divideLetters.Length / partitions;

        List<string> letterToInsert = new List<string>();
        data.RemoveAt(startIndex);
        var letterCounter = 0;
        for (var i = 0; i < partitions; i++)
        {
            var currentLetter = "";
            if (i == partitions - 1)
            {
                for (var j = letterCounter; j < divideLetters.Length; j++)
                {
                    currentLetter += divideLetters[j].ToString();
                    letterCounter++;
                }
                letterToInsert.Add(currentLetter);
                data.InsertRange(startIndex, letterToInsert);
                return data;
            }
            
            for (var j = 0; j < partitionSize; j++)
            {
                currentLetter += divideLetters[letterCounter].ToString();
                letterCounter++;
            }
            letterToInsert.Add(currentLetter);
        }
        data.InsertRange(startIndex, letterToInsert);


        return data;
    }

}


/*
Ivo Johny Tony Bony Mony
merge 0 3
merge 3 4
merge 0 3
3:1

*/