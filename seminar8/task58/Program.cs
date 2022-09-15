// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Умножение матриц

    // |a11 a21 a1m|       |b11 b21 b1n|       |c11 c21 c1n|
    // |a21 a22 a2m|   x   |b21 b22 b2n|   =   |c21 c22 c2n| 
    // |al1     alm|       |bm1 b22 bmn|       |cl1 cl1 cln|
    // L - кол. строк 1 матрицы; M - кол. столбцов 1 матрицы, кол. строк 2 матрицы; N - кол. столбцов 2 матрицы
    // L - кол. строк результирующей матрицы, N - количество столбцов результирующей матрицы 

    // cij = r=1 ... m SUM (air * brj) j= 1 ..l ; j = 1 .. n
    // умножение двух матриц выполнимо если число столбцов в 1 матрице равно числу строк во втором


int[,] MultMatrix(int[,] A, int[,] B)
// L - кол. строк 1 матрицы; M - кол. столбцов 1 матрицы, кол. строк 2 матрицы; N - кол. строк 2 матрицы
// L - кол. строк результирующей матрицы, N - количество столбцов результирующей матрицы 
{
    int L = A.GetLength(0); 
    int M = A.GetLength(1);
    int N = B.GetLength(1);
    //Console.WriteLine($"L = {L}, M= {M}, N = {N}");
    int[,] C = new int[L, N];
    for (int i = 0; i < L; i++)
    {
        for (int j = 0; j < N; j++)
        {
           C[i,j] = 0; 
           for (int r = 0; r < M ; r++)
           {
                C[i,j] += A[i,r]*B[r,j];
                //Console.WriteLine($"r = {r}, i= {i}, j = {j}");
           }

        }
            
    }
    return C;
}


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


Console.WriteLine("START");

Console.WriteLine("умножение двух матриц выполнимо если число столбцов в 1 матрице равно числу строк во втором");
// L - кол. строк 1 матрицы; M - кол. столбцов 1 матрицы, кол. строк 2 матрицы; N - кол. строк 2 матрицы
// L - кол. строк результирующей матрицы, N - количество столбцов результирующей матрицы  
Console.Write("Введите количество строк первой матрицы:");
int Lm = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы:");
int Mm = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк второй матрицы:");
int Nm = int.Parse(Console.ReadLine());


Console.Write("Введите минимальное значение:");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение:");
int max = int.Parse(Console.ReadLine());

int[,] arrayA = GetArray(Lm, Mm, min, max);
Console.WriteLine("Массив А");
PrintArray(arrayA);

int[,] arrayB = GetArray(Mm, Nm, min, max);
Console.WriteLine("Массив B");
PrintArray(arrayB);

int[,] arrayC = MultMatrix(arrayA,  arrayB);

Console.WriteLine("Результат умножения А на В:");
PrintArray(arrayC);


