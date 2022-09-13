// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[] GetLineSumArray(int[,] array)
{
    int[] dumpline = new int[array.GetLength(0)];
    // Go to the Row
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int lineSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            lineSum += array[i,j];
        }
        dumpline[i] = lineSum;              
    }
    return dumpline;
}

int GetLineNumberMin(int[] array)
{
    int LineNumberMin = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            LineNumberMin = i;
        }
    }
    return LineNumberMin;
}





Console.WriteLine("START");

Console.Write("Введите количество строк:");

int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение:");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение:");
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
Console.WriteLine("Исходный массив");
PrintArray(myArray);

int[] MyLine = GetLineSumArray(myArray);

// Console.WriteLine(String.Join(" ", MyLine));

Console.WriteLine($"Номер строки : {GetLineNumberMin(MyLine) + 1}");
