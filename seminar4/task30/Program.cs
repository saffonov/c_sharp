// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int GetRandomArray (int number)
{
    int[] myIntArray = new int[number];
    for (int i = 1; i <= number; i++)
    {
    // Console.WriteLine($"i {i}, number {number} ");
    myIntArray[i] = int Random(0, 2);
    }
    return myIntArray;
}

Console.Write($"Умножение : {GetRandomArray(8)}");