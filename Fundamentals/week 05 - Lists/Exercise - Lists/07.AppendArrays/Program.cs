namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var incomingArr = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);
            for (var i = incomingArr.Length - 1; i >= 0; i--)
            {
                incomingArr[i] = incomingArr[i].Trim();
                var newList = incomingArr[i].Split( " ", StringSplitOptions.RemoveEmptyEntries);;
                foreach (var t in newList)
                {
                    Console.Write(t + " ");
                }
            }
        }
    }
}
