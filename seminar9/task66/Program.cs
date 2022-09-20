// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumFromMtoN(int m , int n)
{
    if (m > n) return 0;
    //Console.WriteLine($"{m} , ");
    return m = m + SumFromMtoN(m+1 , n);
}


Console.WriteLine("Enter M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine());

if (M > N) Console.WriteLine("ERROR! M biggest  N");
else Console.WriteLine($"Sum form {M} to {N} : {SumFromMtoN(M , N)}");
