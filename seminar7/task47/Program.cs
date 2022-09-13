// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

///

double[,] GetRNDArray (int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
       result[i, j] = new Random().Next(minValue*10, (maxValue + 1)*10)/10.0;
       }
    }
    return result;
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
       Console.Write($"{array[i,j]}\t");
       }
       Console.WriteLine();
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

double[,] myArray = GetRNDArray (m, n, min, max);


Console.WriteLine("Сгенерированый массив:");
PrintArray(myArray);
Console.WriteLine(String.Empty);

