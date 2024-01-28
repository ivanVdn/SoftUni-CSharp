/*Курсът "Train the trainers" е към края си и финалното оценяване наближава. Вашата задача е да помогнете на журито което ще оценява презентациите, като напишете програма в която да изчислява средната оценка от представянето на всяка една презентация от даден студент, а накрая средният успех от всички тях.
*/
/* Вход
От конзолата на първият ред се прочита броят на хората в журито n - цяло число в интервала [1…20]
След това на отделен ред се прочита името на презентацията - текст
За всяка една презентация на нов ред се четат n - на брой оценки - реално число в интервала [2.00…6.00]
След изчисляване на средната оценка за конкретна презентация, на конзолата се печата
*/
/*Изход
 "{името на презентацията} - {средна оценка}."
След получаване на команда "Finish" на конзолата се печата "Student's final assessment is {среден успех от всички презентации}." и програмата приключва.
Всички оценки трябва да бъдат форматирани до втория знак след десетичната запетая.
*/


//input
int juryCount = int.Parse(Console.ReadLine());
string presentationName = Console.ReadLine();

double totalAverageGrade = 0;
int presentationsCount = 0;

//calculation and output
while (presentationName != "Finish")
{
    double totalGrade = 0;

    for (int i = 0; i < juryCount; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        totalGrade += grade;
    }

    double averageGrade = totalGrade / juryCount;
    totalAverageGrade += averageGrade;
    presentationsCount++;

    Console.WriteLine($"{presentationName} - {averageGrade:F2}.");

    presentationName = Console.ReadLine();
}

double finalAverageGrade = totalAverageGrade / presentationsCount;

Console.WriteLine($"Student's final assessment is {finalAverageGrade:F2}.");
