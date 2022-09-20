// Задача 67: Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumFigure (int number)
{
    if (number == 0) return 0;

    return number % 10 + SumFigure(number/10); // почему n/10
}



Console.WriteLine("Enter number");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"{SumFigure(n)}");