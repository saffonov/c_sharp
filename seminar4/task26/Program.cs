// Задача 26: 
// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumDigit (int number)
{
    int i = 0;
    while (number > 0)
    {
    number = number /10;
    // Console.WriteLine($"i {i}, number {number} ");
    i++;
    }
    return i;

}

Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine());

Console.Write($"Количество чисел : {GetNumDigit(N)}");
