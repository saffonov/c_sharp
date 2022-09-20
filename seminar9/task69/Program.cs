// Задача 69: Напишите программу, которая на вход принимает два числа 
// A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Pow(int number, int stepen)
{
    if (stepen == 0) return 1;
    return number * Pow(number, stepen-1);

}


Console.WriteLine("Enter number A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number B");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{Pow(A , B)}");