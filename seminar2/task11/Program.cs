// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(0, 1000); // random [a, b)

int a1 = num % 10;
int a3 = num / 100;

Console.WriteLine($"num {num}, a1 {a1}, a3: {a3}");

int Resultat = a3 * 10 + a1;

Console.WriteLine($"Resultat, {Resultat}");
