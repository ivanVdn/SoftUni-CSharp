﻿/*
Ани отива до родния си град след много дълъг период извън страната. Прибирайки се вкъщи тя вижда старата библиотека на баба си и си спомня за любимата си книга. Помогнете на Ани, като напишете програма в която тя въвежда търсената от нея книга(текст). Докато Ани не намери любимата си книга или не провери всички в библиотеката, програмата трябва да чете всеки път на нов ред името на всяка следваща книга (текст). Книгите в библиотеката са свършили щом получите текст "No More Books".
•	Ако не открие търсената книгата да се отпечата на два реда: 
o	"The book you search is not here!"
o	"You checked {брой} books."
•	Ако открие книгата си се отпечатва един ред:
o	"You checked {брой} books and found it."  
*/

//input
string book = Console.ReadLine();
string input = "";
int count = 0;

//calculations
while (input != book)
{
    input = Console.ReadLine();
    count++;
    if (input == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {count-1} books.");
        return;
    }
   
}
//output
Console.WriteLine($"You checked {count-1} books and found it.");