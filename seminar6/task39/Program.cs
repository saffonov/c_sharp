// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] ReverseArray(int[] array) 
{
    int size = array.Length;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[size - 1 - i];
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }

    return res;
}

void ReverseArray2(int[] array) 
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] myArray = GetArray(10, 0, 10);
Console.Write(String.Join(" ", myArray));
Console.WriteLine();
Console.Write(String.Join(" ", ReverseArray(myArray)));
Console.WriteLine();
ReverseArray2(myArray);
Console.Write(String.Join(" ", myArray));
