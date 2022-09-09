// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int[,] GetArray (int m, int n, int minValue, int maxValue)
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
       Console.Write($"{array[i,j]} ");
       }
       Console.WriteLine();
    }



Console.Write("Введите размер1 массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите размер2 массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());


    Console.Write("Сгенерированый массив [");
    Console.Write(String.Join(", ", myArray));
    Console.WriteLine("]");
    // Console.WriteLine($"Максимум массива: {GetMaxArray(myArray)}");
    // Console.WriteLine($"Минимум массива: {GetMinArray(myArray)}");
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {(GetMaxArray(myArray) - GetMinArray(myArray)):f2}");
};


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
    
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }

//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// int min = int.Parse(Console.ReadLine());
// int max = int.Parse(Console.ReadLine());

// int[,] myArray = GetArray(m, n, min, max);
// PrintArray(myArray);
