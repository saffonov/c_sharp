// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int GetAmountNumber (int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
      if (item > 0) result++;  
    }
    return result;
}

Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());

if (m < 0) Console.WriteLine("Количество числе должно быть больше нуля");
else
{
    int[] arrayNumbers = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1} число:");
        arrayNumbers[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Количестово чисел больше нуля : {GetAmountNumber(arrayNumbers)}");
};

