// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// Реализовать функцию возведения в степень самостоятельно!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetAinB(int number, int stepen)
{
    int result = 1;
    for (int i = 1; i <= stepen; i++)
    {
        // Console.WriteLine($"i {i}, result {result} ");
        result = result * number;
    }
    return result;
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

if (B < 1) Console.Write("ОШИБКА! Число B не натуральное ");
else Console.Write($"{A} в степени {B} = {GetAinB(A , B)}");
