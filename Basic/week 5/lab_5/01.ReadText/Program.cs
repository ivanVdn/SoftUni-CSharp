/*
Напишете програма, която чете текст от конзолата (стринг) и го принтира, докато не получи командата "Stop". 
*/

//input
string word = Console.ReadLine();

//calculation and output
while (word != "Stop")
{
    Console.WriteLine(word);
    word = Console.ReadLine();
}