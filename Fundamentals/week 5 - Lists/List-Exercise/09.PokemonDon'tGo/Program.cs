using System.Linq;

namespace _09.PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var sum = 0;

            var indexFromInput = int.Parse(Console.ReadLine());

            for (var i = 0; i < inputList.Count; i++)
            {
                var lastIndex = inputList.Count - 1;
                var element = 0;
                if (indexFromInput < 0)
                {
                    element = inputList[0];
                    inputList.RemoveAt(0);
                    inputList.Insert(0, inputList[lastIndex]);
                    sum += element;
                    inputList = UpdateList(inputList, element);
                }
                // else if (indexFromInput > lastIndex)
                if (indexFromInput > lastIndex)
                {
                    element = inputList[lastIndex];
                    inputList.RemoveAt(lastIndex);
                    inputList.Add(inputList[0]);
                    sum += element;
                    inputList = UpdateList(inputList, element);
                }
                //else
                if (indexFromInput > 0 && indexFromInput <= lastIndex)
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
            for (int j = 0; j < inputList.Count; j++)
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
//Result = 6 + 11 + 15 + 5 + 2 + 4 + 8 = 51.
