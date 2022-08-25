// Случайное число из [10, 99] и показать наибольшую цифру числа

int num = new Random().Next(10, 100); // random [a, b)
int a1 = num % 10;
int a2 = num / 10;

// 123 % 10 = 3
// 123 % 100 = 12 

int max = a1;

if (max < a2)
{
    max = a2;
}

Console.WriteLine($"num, {num} max: {max}");

