/*
5.3
6.01

5.00000001
5.00000003

5.00000005
5.00000001

-0.0000007
0.00000007

-4.999999
-4.999998

4.999999
4.999998

*/


double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

double diff = Math.Abs(firstNumber - secondNumber);
double eps = 0.000001;

if (diff > eps)
{
    Console.WriteLine("False");
}
else
{
    Console.WriteLine("True");
}
