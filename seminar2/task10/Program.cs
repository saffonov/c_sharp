// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число : ");
int num = int.Parse(Console.ReadLine());

if ((num > 999) || (num < -999)) Console.Write("ОШИБКА! Введено не трехзначное число");
else
{
    int result = (num % 100) / 10;
    Console.WriteLine($"Вторая цифра: {result}");
}