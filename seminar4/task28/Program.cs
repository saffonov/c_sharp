// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int GetMult (int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
    // Console.WriteLine($"i {i}, number {number} ");
    mult = mult*i;
    }
    return mult;

}

Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine());

Console.Write($"Умножение : {GetMult(N)}");