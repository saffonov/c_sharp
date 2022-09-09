// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int ConvertDecToBin(int dec)
{
int reverseBin = 0;
while (dec > 1)
{
    reverseBin = dec % 2;
    dec = dec/2;
    Console.WriteLine($"Двоичное число:  {dec}, {reverseBin}");
}
return reverseBin;
}


Console.Write($"Введите число: ");
int numbers= int.Parse(Console.ReadLine());

int bin = ConvertDecToBin(numbers);

Console.Write($"Двоичное число:  {bin}");
