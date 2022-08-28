// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число : ");
int num = int.Parse(Console.ReadLine());

if (num < -99999  || num > 99999) Console.Write("ОШИБКА! Число не пятизначное");
else
{
    // calculate digit for 0, 1, 3, 4 position of number
    int b0 = num % 10;
    int b1 = (num % 100) / 10;
    int b3 = (num % 10000) / 1000;
    int b4 = (num % 100000) / 10000;

 //   Console.WriteLine($"b0 = {b0}, b1 = {b1}, b3 = {b3}, b4 = {b4}");

    if (b0 == b4 && b1 == b3) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
    
};

