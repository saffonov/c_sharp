// Задача 13: 
// Напишите программу, которая выводит третью цифру (слева направо) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());

if ((num < 99) && (num > -99)) Console.Write("третьей цифры нет");
else
{
    int result = (num % 1000) / 100;
    Console.WriteLine($"Третья цифра: {result}");
}

// Console.Write("Введите второе число : ");
// int b = int.Parse(Console.ReadLine());

// int num = a % b;

// // Console.WriteLine($"num, {num}");

// if (num == 0) Console.WriteLine("кратно");
// else Console.WriteLine($"не кратно, остаток {num}");
