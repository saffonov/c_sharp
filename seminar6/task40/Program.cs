// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон


bool ChechTriangle(int[] array)
{
    return (array[0] < array[1] + array[2])&&(array[1] < array[2] + array[0])&&(array[2] < array[0] + array[1]);
}


int noPoint = 3;
int[] numbers = new int[noPoint];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите {i+1} число: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(String.Join(" ", numbers));
if (ChechTriangle(numbers)) Console.Write("YES");
else Console.Write("NO");
