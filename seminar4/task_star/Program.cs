// Задача “со звездочкой”: Напишите функцию, которая принимает 
// одно число - высоту елочки и рисует ее в консоли звездочками.

// 5 ->
//                 *
//                ***
//               *****
//              *******
//             *********

void PrintLine (int[] PrnArray, string star, string dumpStar)
{
    for (int i = 0; i < PrnArray.Length;  i++)
    {
    if (PrnArray[i] == 0) Console.Write(dumpStar);
    else Console.Write(star);
//     Console.Write($"{PrnArray[i]} ");
    }
    Console.WriteLine(" ");
}

void GetStar (int H, string star, string dumpStar)
{
    int stringLeght = 2*H - 1; // длинна строки
    int[]  elkaLine = new int[stringLeght];
    int leftIndex = stringLeght / 2;
    int righIndex = stringLeght / 2;
   
//    Console.WriteLine($"stringLeght = {stringLeght} ");

   for (int i = 0; i < H; i++)
   {
//    Console.WriteLine($"leftIndex = {leftIndex} , righIndex = {righIndex} ");
    elkaLine[leftIndex] = 1;
    elkaLine[righIndex] = 1;

    leftIndex--;
    righIndex++;

    PrintLine(elkaLine, star, dumpStar);
    }
    
}

Console.Write("Введите высоту елочки: ");
int hElka = int.Parse(Console.ReadLine());

if (hElka <1) Console.Write("ОШИБКА! Высота елки должна быть не менее единицы");
else if (hElka > 39) Console.Write("ОШИБКА! Высота елки слишком большая - елка не уместится в консоли");
else GetStar(hElka, "*", " ");