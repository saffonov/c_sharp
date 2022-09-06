// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetRNDarray (int N, int a, int b)
{
    double[] RNDarray = new double[N];
    for (int i = 0; i < RNDarray.Length; i++)
    {
       RNDarray[i] = (new Random().Next(a, b)) / 100.0;
    }
    return RNDarray;
}


double GetMaxArray (double[] array)
{
    double maxArray = array[0];
    foreach (double element in array)
    {
        if (maxArray < element) maxArray = element;
    }
    return maxArray;
}

double GetMinArray (double[] array)
{
    double minArray = array[0];
    foreach (double element in array)
    {
        if (minArray > element) minArray = element;
    }
    return minArray;
}


Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int B = int.Parse(Console.ReadLine());

// It`s a MAGIC int --> double for 2 digit after .
// int A --> A*100 --> randomaze --> /100 --> double
A = A*100;
B = B*100;

if (N < 2) Console.WriteLine("Размер массива должен быть больше 2");
else if (A > B) Console.WriteLine("максимальное значение массива должно минимального");
else
{
    double[] myArray = GetRNDarray(N, A, B);

    Console.Write("Сгенерированый массив [");
    Console.Write(String.Join(", ", myArray));
    Console.WriteLine("]");
    // Console.WriteLine($"Максимум массива: {GetMaxArray(myArray)}");
    // Console.WriteLine($"Минимум массива: {GetMinArray(myArray)}");
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {(GetMaxArray(myArray) - GetMinArray(myArray)):f2}");
};
