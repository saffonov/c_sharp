// 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число : ");
int a = int.Parse(Console.ReadLine());

int num7 = a % 7;
int num23 = a % 23;

// Console.WriteLine($"num, {num}");

if ((num7 == 0) && (num23 == 0) )
{
    Console.WriteLine("кратно");
}
else Console.WriteLine("нет");