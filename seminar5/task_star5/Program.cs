// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
// Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetRNDarray (int N, int a, int b)
{
    int[] RNDarray = new int[N];
    for (int i = 0; i < RNDarray.Length; i++)
    {
       RNDarray[i] = new Random().Next(a, b);
    }
    return RNDarray;
}

int[] SortBubbleDerise (int[] array)
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
    Console.Write(String.Join(", ", SortBubbleDerise(myArray)));
};