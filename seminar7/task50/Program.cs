// Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

void LookForN(int N, int[,] array)
{  
    bool flagNotFind = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == N) 
            {
              Console.WriteLine($"Индексы заданного числа {N} : {i} , {j} ");
              flagNotFind = false; 
              return;              
            };
        }
    }
    if (flagNotFind) Console.WriteLine($"Такого числа в массиве нет");
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

Console.Write("Введите число для поиска: ");
int nLookFor = int.Parse(Console.ReadLine());



Console.WriteLine("Сгенерированый массив:");
PrintArray(myArray);
Console.WriteLine(String.Empty);

LookForN(nLookFor, myArray);
