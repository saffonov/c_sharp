// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetRNDarray (int N, int a, int b)
{
    int[] RNDarray = new int[N];
    for (int i = 0; i < RNDarray.Length; i++)
    {
       RNDarray[i] = new Random().Next(a, b);
    }
    return RNDarray;
}

int CalculateOddPosition (int[] array)
{
    int result = 0;
       for (int i = 1; i < array.Length; i +=2)
    {
        result += array[i];
        // Console.WriteLine($"i = {i}, array = {array[i]}, result = {result}");
    }
    return result;
}

Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int B = int.Parse(Console.ReadLine());

if (N < 2) Console.WriteLine("Размер массива должен быть больше 2");
else if (A > B) Console.WriteLine("максимальное значение массива должно минимального");
else
{
    int[] myArray = GetRNDarray(N, A, B);

    Console.Write("Сгенерированый массив [");
    Console.Write(String.Join(", ", myArray));
    Console.WriteLine("]");
    Console.WriteLine($"Сумма  чисел на нечетной позиции: {CalculateOddPosition(myArray)}");
};
