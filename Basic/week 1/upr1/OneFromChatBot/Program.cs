
using System;

class Program
{
    static void Main()
    {
        // Текущ обменен курс - променете го, ако е необходимо
        decimal usdToBgnExchangeRate = 1.79m;

        Console.Write("Въведете сума в USD: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal usdAmount))
        {
            decimal bgnAmount = usdAmount * usdToBgnExchangeRate;
            Console.WriteLine($"Сума в BGN: {bgnAmount:F2}");
        }
        else
        {
            Console.WriteLine("Грешка при въвеждане на сумата.");
        }
    }
}
