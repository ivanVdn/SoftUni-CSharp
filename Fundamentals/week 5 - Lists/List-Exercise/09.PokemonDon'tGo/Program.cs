using System.Linq;

namespace _09.PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var sum = 0;

            while (inputList.Count > 0)
            {
                var indexFromInput = int.Parse(Console.ReadLine());
                var element = 0;


                if (indexFromInput < 0)
                {
                    element = inputList[0];
                    inputList.RemoveAt(0);
                    inputList.Insert(0, inputList[inputList.Count - 1]);
                    sum += element;
                    inputList = UpdateList(inputList, element);
                }
                else if (indexFromInput > inputList.Count - 1)
                {

                    element = inputList[inputList.Count - 1];
                    inputList.RemoveAt(inputList.Count - 1);
                    inputList.Add(inputList[0]);
                    sum += element;
                    inputList = UpdateList(inputList, element);
                }
                else
                {
                    element = inputList[indexFromInput];
                    inputList.RemoveAt(indexFromInput);
                    sum += element;
                    inputList = UpdateList(inputList, element);
                }

            }
            Console.WriteLine(sum);
        }

        private static List<int> UpdateList(List<int> inputList, int element)
        {
            for (var j = 0; j < inputList.Count; j++)
            {
                if (inputList[j] <= element)
                {
                    inputList[j] += element;
                }
                else if (inputList[j] > element)
                {
                    inputList[j] -= element;
                }
            }

            return inputList;
        }
    }
}
