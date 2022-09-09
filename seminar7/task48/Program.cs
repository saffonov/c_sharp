// Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CalculateArray(int M, int N, int[,] array)
{
    int[,] result = new int[M, N];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}


int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

Console.WriteLine("Исходный массив");

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
myArray = CalculateArray(m, n, myArray);

Console.WriteLine("Вычисленный  массив");

PrintArray(myArray);