/*
Напишете програма, в която Марин решава задачи от изпити докато не получи съобщение "Enough" от лектора си. При всяка решена задача той получава оценка. Програмата трябва да приключи прочитането на данни при команда "Enough" или ако Марин получи определения брой незадоволителни оценки.
Незадоволителна е всяка оценка, която е по-малка или равна на 4.
*/
/*Вход
•	На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]
•	След това многократно се четат по два реда:
o	Име на задача - текст (низ)
o	Оценка - цяло число в интервала [2…6]
*/
/*Изход
•	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда: 
o	"Average score: {средна оценка}"
o	"Number of problems: {броя на всички задачи}"
o	"Last problem: {името на последната задача}"
•	Ако получи определеният брой незадоволителни оценки:
o	"You need a break, {брой незадоволителни оценки} poor grades."
Средната оценка да бъде форматирана до втория знак след десетичната запетая. 
*/


//input
int maxBadGrade = int.Parse(Console.ReadLine());
int badGradeCount = 0;
int grade = 0;
int gradeSum = 0;
int gradeCount = 0;
string exercises = "";
string word = "";
bool flag = false;


//calculations and output
while (exercises != "Enough")
{
    exercises = Console.ReadLine();
        if (exercises == "Enough") {flag = true;break;}
    grade = int.Parse(Console.ReadLine());  
    gradeSum += grade;
        if (grade <= 4){badGradeCount++;}
        if (badGradeCount == maxBadGrade){Console.WriteLine($"You need a break, {badGradeCount} poor grades.");break;}
    gradeCount++;
    word = exercises;
}
if (flag) 
{ 
    double averageGrade = gradeSum / (double)gradeCount;
    Console.WriteLine($"Average score: {averageGrade:f2}");
    Console.WriteLine($"Number of problems: {gradeCount}");
    Console.WriteLine($"Last problem: {word}");
}