// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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


void ChangeRows(int[,] arr)
{
    int firstRow = 0;
    int lastRow = arr.GetLength(0) - 1;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        var temp = arr[firstRow, i];
        arr[firstRow, i] = arr[lastRow, i];
        arr[lastRow, i] = temp;
    }
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

int[,] arr = GetArray(m, n, min, max);
Console.WriteLine("Исходный массив");
PrintArray(arr);

ChangeRows(arr);

Console.WriteLine("Измененный массив");
PrintArray(arr);
// Console.WriteLine(GetSumDiagonal(myArray));

