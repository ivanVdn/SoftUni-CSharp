/*
Напишете програма, която изчислява средната оценка на ученик от цялото му обучение. На първия ред ще получите името на ученика, а на всеки следващ ред неговите годишни оценки. Ученикът преминава в следващия клас, ако годишната му оценка е по-голяма или равна на 4.00. Ако ученикът бъде скъсан повече от един път, то той бива изключен и програмата приключва, като се отпечатва името на ученика и в кой клас бива изключен.
 
*/
/*  Изход
При успешно завършване на 12-ти клас да се отпечата : 
"{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
В случай, че ученикът е изключен от училище, да се отпечата:
"{име на ученика} has been excluded at {класа, в който е бил изключен} grade"
Стойността трябва да бъде форматирана до втория знак след десетичната запетая.  

*/


/* решение от лекции
//input
string name = Console.ReadLine();
int klas = 1;
int badGrades = 0;
double allGrades = 0;
//calculations and output
while (klas <= 12)
{
    double curentGrade = double.Parse(Console.ReadLine());
    if (curentGrade < 4)
    {
        badGrades++;
        if (badGrades == 2)
        {
            Console.WriteLine($"{name} has been excluded at {klas} grade");
            break;
        }
        continue;
    }
    klas ++;
    allGrades += curentGrade;
}
if (klas >= 12)
{
    double averageGrade = allGrades / 12;
    Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
}

*/


/* мое решение 
//input
string name = Console.ReadLine();
double count = 1;
double badGrades = 0;
double sumOfAllGrades = 0;

//calculations
while (count <= 12)
{
    double grades = double.Parse(Console.ReadLine());
    if (grades < 4)
    {
        badGrades ++;
        if (badGrades == 2)
        {
            Console.WriteLine($"{name} has been excluded at {count} grade");
            break;
        }
        continue;
    }
    if (grades >= 4)
    {
        sumOfAllGrades += grades;
        count ++;    
    }
}

//output
if (count >= 12)
{
    double average = sumOfAllGrades / 12;
    Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
}
*/

//input
string studentName = Console.ReadLine();
double badAssessmentCount = 0;
double assessmentCout = 1;
double OverallAssessment = 0;
//calculations and output
while (assessmentCout <= 12)
{
    double assessment = double.Parse(Console.ReadLine());
    if (assessment < 4)
    {
        badAssessmentCount++;
        if (badAssessmentCount == 2)
        {
            Console.WriteLine($"{studentName} has been excluded at {assessmentCout} grade");
            break;
        }
        continue;
    }
    assessmentCout++;
    OverallAssessment += assessment;
}
if (assessmentCout >= 12)
{
    Console.WriteLine($"{studentName} graduated. Average grade: {OverallAssessment / 12:f2}");
}