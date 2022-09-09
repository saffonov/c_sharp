// Задача со звездочкой. Напишите программу, которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.

// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

int[,] GetRNDarrayMxN(int m, int n, int minValue, int maxValue)
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

void PrintArrayMxN(int[,] array)
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

void PrintArroudArrayMxN (int startM, int startN, int stopM, int stopN, int[,] array)
{
    // [stopM, startN]      [stopM, stopN]    
    // [startM, startN]     [startM, stopN]
    // startN --> stopN,        startM = const
    // startM-1 ^ stopM,        stopN = const
    // stopN-1 <-- startN,      stopM = const
    //  stopM+1 V startM-1,     startN = const   

    //Console.WriteLine($"Move to right  ");
    for (int i = startN; i <= stopN; i++) Console.Write($"{array[startM, i]} "); // --->
    //Console.WriteLine($"Move to up ");
    for (int i = startM-1; i >= stopM; i--) Console.Write($"{array[i, stopN]} "); // ^
    //Console.WriteLine($"Move to left ");
    for (int i = stopN-1; i >= startN; i--) Console.Write($"{array[stopM, i]} "); // <---
    //Console.WriteLine($"Move to down ");
    for (int i = stopM+1; i < startM; i++) Console.Write($"{array[i, startN]} "); // V
}



Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = new int[m, n];
myArray = GetRNDarrayMxN(m, n, 0, 100);

PrintArrayMxN(myArray);

int startM = myArray.GetLength(0) - 1;
int startN = 0;
int stopM = 0;
int stopN = myArray.GetLength(1) - 1;

// start MAGIC
// When amount row < colun PrintArroudArrayMxN print stop digit double 
// fixed magic: finalstep = 1
int amountStep = myArray.GetLength(0)/2;
if (amountStep > myArray.GetLength(1)/2) amountStep =myArray.GetLength(1)/2;

int finishStep = 0;
if (myArray.GetLength(0) < myArray.GetLength(1)) finishStep = 1;
// end MAGIC

for (int i = amountStep; i >= finishStep; i--)
{
    //Console.WriteLine($"Следующий проход: i = {i} , startM = {startM} , startN = {startN} , stopM = {stopM} , stopN = {stopN}");
    PrintArroudArrayMxN(startM, startN, stopM, stopN, myArray); 

    // [stopM, startN]      [stopM, stopN]    
    // [startM, startN]     [startM, stopN]
    // startN --> stopN,        startM = const
    // startM-1 ^ stopM,        stopN = const
    // stopN-1 <-- startN,      stopM = const
    //  stopM+1 V startM-1,     startN = const  
    startM--;
    stopM++;
    startN++;
    stopN--;

}



