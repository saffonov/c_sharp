// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// или квадратной матрицы MxM
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] GetSpiralArray(int M)
// startI startJ    startI stopJ
// stopI startJ     stopI stopJ

{
    int[,] array = new int[M, M];
    int count = 0;
    int loopCount = 0;
    int startI = 0;
    int stopI = M;
    int startJ = 0;;
    int stopJ = M;
    int centerIndex = M/2;
    
    while (loopCount < M/2)
    {
        // Console.WriteLine($"count: {count} ,  startI: {startI} ,  stopI: {stopI} ,  startJ: {startJ} ,  stopJ: {stopJ}");
        //Console.WriteLine($"Move to right  ");
        for (int i = startJ; i < stopJ; i++) // --->
        {   
            array[startI, i] = count;
            count++;
        //    Console.Write($"{array[startI, i]} ");
        } 
        // Console.WriteLine($"Move to down ");
        for (int i = startI+1; i < stopI; i++) // V
        {
            array[i, stopJ-1] = count;
            count++;
            //Console.Write($"{array[i, stopJ-1]} ");
        } 
        // Console.WriteLine($"Move to left ");
        for (int i = stopJ-2; i >= startJ; i--) // <---
        {
            array[stopI-1, i] = count;
            count++;    
            // Console.Write($"{array[stopI-1, i]} ");
        } 
        // Console.WriteLine($"Move to up ");
        for (int i = stopI-2; i > startI; i--) // ^ 
        {
            array[i, startJ] = count;
            count++;   
            // Console.Write($"{array[i, startJ]} "); 
        }
        //MAGIC for even M - center element
        // [*] - if even
        if (M % 2 == 1) 
        {
            array[centerIndex, centerIndex] = count;
            Console.Write($"{array[centerIndex, centerIndex]} "); 
        }
        // END MAGIC

        loopCount++;
        startI++;
        stopI--;
        startJ++;
        stopJ--;
    }
    return array;
}


Console.WriteLine("START");

Console.Write("Введите размер квадратной матрицы:");
int M = int.Parse(Console.ReadLine());

int[,] myArray = GetSpiralArray(M);

Console.WriteLine("Массив:");
PrintArray(myArray);




