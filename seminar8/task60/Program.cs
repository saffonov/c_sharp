// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool CheckCellArrayForExclusive(int number, int[,,] array)
{
    bool result = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == number) result = false;
                return result;
            }
       }
    }
    return result;
}

int[,,] GetExclusiveRNDArray(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] array = new int[m, n, l];

        for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
            int k = 0;
            while (k < array.GetLength(2))
            {
                int num = new Random().Next(minValue, maxValue + 1);
                bool flag = CheckCellArrayForExclusive(num, array);
                if (flag) 
                {
                    array[i,j,k] = num;
                    k++;
                }    
            }
       }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
             for (int j = 0; j < array.GetLength(1); j++)
             {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
             }
            Console.WriteLine();    
        }
    }
}



Console.WriteLine("START");

// Console.Write("Введите минимальное значение:");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Введите минимальное значение:");
// int max = int.Parse(Console.ReadLine());

int[,,] arrayA = GetExclusiveRNDArray(2, 2, 2, 10, 98);
Console.WriteLine("Массив А");
PrintArray(arrayA);



