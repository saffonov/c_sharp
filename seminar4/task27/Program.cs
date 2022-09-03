// Задача 27: Напишите функцию и запустите ее, 
// которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int number)
// "123" -->        1 + 2 + 3 = 6
// ? "-123" -->     -1 + 2 + 3 = 4
{
    int result = 0;
    int num = number;
    int digit = 0;

    if (number < 0) num = -1*number;

    while (num > 0)
    {
        digit = num % 10;
        num = num / 10;
        Console.WriteLine($" num {num} ; digit {digit}");
        result = result + digit;
    }

    // It`s a MAGIC
    if (number < 0) result = result - 2*digit;
    // END MAGIC
    
    return result;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

Console.Write($"Сумма цифр в числе {N} = {SumDigit(N)}");
