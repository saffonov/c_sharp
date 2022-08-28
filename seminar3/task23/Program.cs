// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// ? Условие не корректное т.к N может быть отрицательным иил нулевым.
// Можно сделать проверку что N > 1
// if (N < 1) Console.WriteLine("ОШИБКА! число меньше 1 ");
// НО интереснее сделать для любого N

Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine());

int i = 0;

if (N > 0 )
{
    for (i=1; i<=N; i++)
    {
        if (i<N) Console.Write($"{i*i*i}, ");
        else Console.WriteLine($"{i*i*i}");
    }
}
else 
{
    for (i=1; i >= N; i--)
    {
        if (i>N) Console.Write($"{i*i*i}, ");
        else Console.WriteLine($"{i*i*i}");
    }
}