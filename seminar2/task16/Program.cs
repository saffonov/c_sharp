// 16. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите первое число : ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число : ");
int b = int.Parse(Console.ReadLine());


// Console.WriteLine($"num, {num}");

if ((a * a == b) || (b * b == a)) Console.WriteLine("да");
else Console.WriteLine("нет");