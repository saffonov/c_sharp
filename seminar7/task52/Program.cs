// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRNDArray(int m, int n, int minValue, int maxValue)
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ColumArithmetical(int[,] array)
{  
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double columSum = 0.0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columSum += array[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j} = {columSum/array.GetLength(0):f2}");
    }
}

Console.Write("Введите размер1 массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите размер2 массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetRNDArray (m, n, min, max);


Console.WriteLine("Сгенерированый массив:");
PrintArray(myArray);
Console.WriteLine(String.Empty);

ColumArithmetical(myArray);

