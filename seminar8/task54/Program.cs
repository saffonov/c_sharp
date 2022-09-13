// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


int[] SortBubbleDerise (int[] array) //void
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j + 1] > array[j])
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

int[,] SortLineArray(int[,] array)
{
    // Go to the Row
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] dumpline = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            dumpline[j] = array[i,j];
        }
        dumpline = SortBubbleDerise(dumpline);

        for (int l = 0; l < array.GetLength(1); l++)
        {
            array[i,l] = dumpline[l];
        }        
    }
    return array;
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

myArray = SortLineArray(myArray);
Console.WriteLine("Отсортированый массив");
PrintArray(myArray);



