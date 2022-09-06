// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetRNDarray (int N, int a, int b)
{
    int[] RNDarray = new int[N];
    for (int i = 0; i < RNDarray.Length; i++)
    {
       RNDarray[i] = new Random().Next(a, b);
    }
    return RNDarray;
}

int CalculateEven (int[] array)
{
    int result = 0;
    foreach (int element in array)
    {
        int flagEvent = element % 2;
        if (flagEvent == 0) result++;
    }
    return result;
}

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

if (n < 1) Console.WriteLine("Размер массива должен быть больше 1");
else
{
    int[] myArray = GetRNDarray(n, 0, 1000);

    Console.Write("Сгенерированый массив [");
    Console.Write(String.Join(", ", myArray));
    Console.WriteLine("]");
    Console.WriteLine($"Количестово четных чисел : {CalculateEven(myArray)}");
};
