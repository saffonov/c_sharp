// Задача 29: Напишите программу, которая задаёт массив из N элементов, 
// заполненных случайными числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19] 
// 3, 1, 35 -> [6, 1, 33]

int[] GetRNDarray (int N, int a, int b)
{
    int[] RNDarray = new int[N];
    for (int i = 0; i < RNDarray.Length; i++)
    {
       RNDarray[i] = new Random().Next(a, b);
    }
    return RNDarray;
}

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите нижний диапазон: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите верхний  диапазон: ");
int B = int.Parse(Console.ReadLine());

Console.Write("[");
Console.Write(String.Join(", ", GetRNDarray(n, A, B)));
Console.WriteLine("]");
  

