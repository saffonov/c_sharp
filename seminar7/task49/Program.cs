// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.


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


void CalculateArray(int[,] array)
{
    // int[,] result = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] = array[i,j]*array[i,j];
        }
        Console.WriteLine();
    }
    //return array
}

Console.WriteLine("START");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
Console.WriteLine("Исходный массив");
PrintArray(myArray);
CalculateArray(myArray);
Console.WriteLine("Вычисленный массив");
PrintArray(myArray);