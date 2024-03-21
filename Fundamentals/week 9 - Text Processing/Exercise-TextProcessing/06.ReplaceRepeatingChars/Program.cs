using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            if (input == null) return;
            var sb = new StringBuilder(capacity: input.Length - 1);

            //var index = 0;
            //while (index < input.Length)
            //{
            //    while (index + 1 < input.Length && input[index] == input[index + 1])
            //        index++;

            //    sb.Append(input[index]);

            //    index++;
            //}


            for (var i = 0; i < input.Length; i++)
            {
                if ( (input[i-1] != input[i]) || i == 0) 
                    sb.Append(input[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
