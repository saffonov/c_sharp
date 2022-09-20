// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

int GetFromMtoN(int m , int n)
{
    if (m > n) return 0;
    Console.Write($"{m} , ");
    return m = GetFromMtoN(m+1 , n);
}


Console.WriteLine("Enter M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine());

if (M > N) Console.WriteLine("ERROR! M biggest  N");
else GetFromMtoN(M , N);



