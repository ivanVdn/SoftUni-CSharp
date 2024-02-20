namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ще ви бъдат дадени две ръце с карти, които ще бъдат представени с цели числа. Да приемем, че всеки се държи от различен играч.
            Трябва да откриете кой има печелившата колода. 
            
            Започвате от началото на двете ръце на картите. Сравнете картите от първото тесте с 
            картите от второто тесте. Играчът, който държи по-мощната карта в текущата итерация, взема двете карти и ги поставя на гърба на 
            ръката си - картата на втория играч се поставя последна, а картата на първия човек (печелившата) идва след нея (втора до последно).
            Ако картите на двамата играчи имат еднакви стойности - никой не печели и двете карти трябва да бъдат премахнати от двете ръце. Играта 
            приключва едва когато една от колодите остане без карти. Трябва да покажете резултата на конзолата и сумата от останалите карти: 
            „{Първи/Втори} играч печели! Сума: {сума}“..
            */
            var firstPlayerList = Console.ReadLine()
                ?.Split()
                .Select(int.Parse)
                .ToList();

            var secondPlayerList = Console.ReadLine()
                ?.Split()
                .Select(int.Parse)
                .ToList();

            var length = Math.Min(firstPlayerList.Count, secondPlayerList.Count);
            for (var i = 0; i < length; i++)
            {
                var cardOne = firstPlayerList[i];
                var cardTwo = secondPlayerList[i];
                if (cardOne > cardTwo)
                {
                    firstPlayerList.Add(cardOne);
                    firstPlayerList.Add(cardTwo);
                    secondPlayerList.RemoveRange(i, 1);
                    firstPlayerList.RemoveRange(i, 1);
                }
                else if (cardOne < cardTwo)
                {
                    secondPlayerList.Add(cardTwo);
                    secondPlayerList.Add(cardOne);
                    firstPlayerList.RemoveRange(i, 1);
                    secondPlayerList.RemoveRange(i, 1);
                }
                else if (cardOne == cardTwo)
                {
                    firstPlayerList.RemoveRange(i, 1);
                    secondPlayerList.RemoveRange(i, 1);
                }

                i = -1;
                length = Math.Min(firstPlayerList.Count, secondPlayerList.Count);
            }

            Console.WriteLine(firstPlayerList.Sum() > secondPlayerList.Sum() ? $"First player wins! Sum: {firstPlayerList.Sum()}" : $"Second player wins! Sum: {secondPlayerList.Sum()}");
        }
    }
}
