// Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, которая принимает 
// на вход целочисленное значение x и 
// возвращает целую часть квадратного корня от введенного числа.
// Нельзя использовать встроенные функции библиотеки Math!
// максимально быстро
// Xk+1 = 0.5(Xk + n/Xk), условие остановки|Xk+1 - Xk| < 1


void GetSqrt(int n)
{
    double x = 1.0;
    double flag = 10.0;
    double xNext =  0.0;

    while (flag > 1)
    {
        xNext =  0.5*(x + n / x);
        flag = xNext - x;
        if (flag < 0) flag = -flag;
        // Console.Write($"xNext: {xNext} ; flag = {flag}");
        x = xNext;
    }
    Console.Write($"Квадратный корень из {n} : {Convert.ToInt32(xNext)}");
}


Console.WriteLine("START");

Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());

GetSqrt(N);

