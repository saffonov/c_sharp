// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

//             [ n+1                   for m = 0
// A(m, n) =   | A(m-1, 1)             for m>0 , n = 0
//             [ A(m-1, A(m, n-1))     for m>0 , n >0

int GetAccerman(int m , int n)
{
    if (m == 0) return n+1;
    if ((m > 0 )&& (n == 0)) return GetAccerman(m-1, 1);
    else return GetAccerman(m-1, GetAccerman(m, n-1));
}


Console.WriteLine("Enter M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine());

if ((M < 0)||(N < 0)) Console.WriteLine("ERROR! M or N dont have to less 0");
else Console.WriteLine($"Accerman for {M} and {N} : {GetAccerman(M , N)}");
