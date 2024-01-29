/*
 Напишете програма, която чете поредица от низове от конзолата. Шифровайте всеки низ чрез сумиране:
• Кодът на всяка гласна, умножен по дължината на низа
• Кодът на всяка съгласна, разделен на дължината на низа
Сортирайте числовата последователност във възходящ ред и я отпечатайте в конзолата.
На първия ред винаги ще получавате броя низове, които трябва да прочетете.

 */

int numberOfElements = int.Parse(Console.ReadLine());

int[] encryptedNames = new int[numberOfElements];

for (int i = 0; i < numberOfElements; i++)
{
    string[] names = Console.ReadLine().Split("",StringSplitOptions.RemoveEmptyEntries);

    int sum = 0; 
    string currentElement;
    for (int j = 0; j < names.Length; j++)
    {
        int n = 0;
        currentElement = names[j];
        for (int k = 0; k < currentElement.Length; k++)
        {
            char[] charArray = currentElement.ToCharArray();
            char c = charArray[k];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                n = (int)c;
                n *= charArray.Length; 
            }
            else
            {
                n = (int)c;
                n /= charArray.Length; 
            }
            sum += n;
        }
    }
    encryptedNames[i] = sum;
    sum = 0;
}

Array.Sort(encryptedNames);

for (int i = 0; i < encryptedNames.Length; i++)
{
    Console.WriteLine(encryptedNames[i]);
}