// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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

int[] Array2Dto1D (int[,] array)
{
    int[] result = new int[(array.GetLength(0) * array.GetLength(1))]; 
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[k] = array[i,j];
            // Console.WriteLine($"i = {i} , j = {j} , k = {k}: {result[k]}  ");
            k++;
            
        }
    }
    return result;
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


void PrintFreq(int[] arr)
{
    int k = arr[0];
    int count = 1;

    for (int i = 1; i < arr.Length; i++)
    {
        if (k == arr[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{k} встречается {count} раз");
            k = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{k} встречается {count} раз");
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

int[] array1D = Array2Dto1D (arr);

Console.WriteLine("Одномерный массив");
Console.WriteLine(String.Join(", ", array1D));

Console.WriteLine("Одномерный сортированный массив");

int[] array1DSort = SortBubbleDerise (array1D);
Console.WriteLine(String.Join(", ", array1DSort));

PrintFreq(array1DSort);





