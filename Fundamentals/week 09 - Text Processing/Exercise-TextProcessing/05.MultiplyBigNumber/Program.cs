using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        internal static void Main()
        {
            var number = Console.ReadLine();
            var multiplayer = int.Parse(Console.ReadLine());

            var sb = new StringBuilder(capacity: number.Length - 1);
            if (multiplayer == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                var carry = 0;
                for (var i = number.Length - 1; i >= 0; i--)
                {
                    var result = (number[i] - '0') * multiplayer + carry;
                    carry = result / 10;
                    sb.Append(result % 10);
                }

                if (carry != 0)
                {
                    sb.Append(carry);
                }

                for (var i = 0; i < sb.Length / 2; i++)
                {
                    // ReSharper disable once SwapViaDeconstruction
                    var t = sb[i];
                    sb[i] = sb[^(i + 1)];
                    sb[^(i + 1)] = t;
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
