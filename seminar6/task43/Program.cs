// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//
// k1 = 5, b1 = 2,  k2 = 9,  b2 = 4-> (-0,5; -0,5)
//
// значения b1, k1, b2 и k2 задаются пользователем.
// пересечение:
// k1 * x + b1 = k2 * x + b2 => x = (b2-b1) /(k1 -k2)
// y = f(x)
// ограничение: b2 = b1 = 0 - исключение , пресечение (0, 0), b2=b1 = (0, b2)
// k1 = k2 - паралельные , пресечений нет


double[] GetCrossPoint(double[,] coeffLine)
{
    // coeffLine
    // k1, b1
    // k2, b2
    double[] crossPoint = new double[2];
    crossPoint[0] = (coeffLine[1, 1] - coeffLine[0, 1]) / (coeffLine[0, 0] - coeffLine[1, 0]);    // crossPoint X
    crossPoint[1] = coeffLine[0, 0] * crossPoint[0] + coeffLine[0, 1];                          // crossPoint Y 
    return  crossPoint;
}

Console.WriteLine("Первая прямая: ");
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Вторая прямая: ");
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = 0;
double y = 0;

if (k1 == k2) 
{
    if (b1 == b2) Console.WriteLine("ТОЧКИ ПЕРЕСЕЧЕНИЯ НЕ СУЩЕСТВУЕТ. Прямые совпадают");
    else Console.WriteLine("ТОЧКИ ПЕРЕСЕЧЕНИЯ НЕ СУЩЕСТВУЕТ. Прямые параллельны");
}
else if (b1 == b2)
{ 
    y = b1;
    Console.WriteLine($"Координаты точки пересечения : ({x} , {y})");
}
else 
{
    
    Console.Write("Координаты точки пересечения : (");
    double[,] coeffLineUser = new double[2, 2]{{k1, b1}, {k2, b2}};
    Console.Write(String.Join(", ", GetCrossPoint(coeffLineUser)));
    Console.WriteLine(") ");
}



