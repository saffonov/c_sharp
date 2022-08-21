
// Homework Seminar1 task8
// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine());

int i = 0;

while (i < N)
{
    i++;
    int flagOdd = i % 2;
    if (flagOdd == 0) Console.Write($"{i} , ");

}
