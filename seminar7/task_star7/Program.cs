// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994
//
//
//  TODO
//  (-) Check maximum romul: < MMMCMXCIX
//  (+) Enter BIG and small letter
//  (+) Do even for input
//
// Правила
// В римском исчислении используют всего семь заглавных букв латинского алфавита.
//     I - 1
//     V - 5
//     X - 10
//     L - 50
//     C - 100
//     D - 500
//     M - 1000

// Натуральные числа записываются при помощи повторения этих цифр.
// При этом, если большая цифра стоит перед меньшей, то они складываются (принцип сложения), если же меньшая стоит перед большей, то меньшая вычитается из большей (принцип вычитания).
// Последнее правило применяется только для исключения четырёхкратного повторения одной и той же цифры.
// Некоторые из цифр (I, X, C, M - единицы в соответствующих разрядах) могут повторяться, но не более трёх раз подряд.
// Принцип вычитания применяется только к шести числам:
//     IV - 4
//     IX - 9
//     XL - 40
//     XC - 90
//     CD - 400
//     CM - 900
// С помощью римских цифр можно записать любое целое число, но не более 3999 (MMMCMXCIX).
// В качестве примера это число и рассмотрим. Выделяем разряды - MMM'CM'XC'IX:
//     MMM - Три подряд символа 1000, т.е. это запись числа 3000
//     CM - Единица в разряде сотен стоит перед десятью в разряде сотен, т.е. применяется принцип вычитания. Это запись числа 900
//     XC - Единица в разряде десятков стоит перед десятью в разряде десятков, т.е. применяется принцип вычитания. Это запись числа 90
//     IX - Единица стоит перед десятью, т.е. применяется принцип вычитания. Это запись числа 9
// В сумме получается 3000 + 900 + 90 + 9 = 3999.

void ConvertRomul2Arabic(string romul)
{
    int numArabic = 0;
    for (int i = romul.Length-1; i >= 0; i-=2)
    {
        //Console.WriteLine($"{i} : {romul[i]}");
        string stringForConverte = string.Concat(romul[i-1] , romul[i]);
        //Console.WriteLine($"stringForConverte : {stringForConverte}");

        switch (stringForConverte)
        //     IV - 4
        //     IX - 9
        //     XL - 40
        //     XC - 90
        //     CD - 400
        //     CM - 900
        {
            case "IV" : 
                numArabic = numArabic + 4;
                break;
            case "IX" : 
                numArabic = numArabic + 9;
                break;
            case "XL" : 
                numArabic = numArabic + 40;
                break;
            case "XC" : 
                numArabic = numArabic + 90;
                break;
            case "CD" : 
                numArabic = numArabic + 400;
                break;
            case "CM" : 
                numArabic = numArabic + 900;
                break;          
            default:
            {
                // NOTE: Convert for TWO digit
                for (int j = 1; j >= 0; j--)
                {
                    char stringOneForConverte =  stringForConverte[j];             

                    switch (stringOneForConverte)
                    {
                        //     I - 1
                        //     V - 5
                        //     X - 10
                        //     L - 50
                        //     C - 100
                        //     D - 500
                        //     M - 1000
                        case 'I' : 
                        numArabic = numArabic + 1;
                            break;
                        case 'V' : 
                            numArabic = numArabic + 5;
                            break;
                        case 'X' : 
                            numArabic = numArabic + 10;
                            break;
                        case 'L' : 
                            numArabic = numArabic + 50;
                            break;
                        case 'C' : 
                            numArabic = numArabic + 100;
                            break;
                        case 'D' : 
                            numArabic = numArabic + 500;
                            break; 
                        case 'M' : 
                            numArabic = numArabic + 1000;
                            break;         
                        default:
                            break;
                    }
                }
            }
            break;
        }
         
    }
    Console.WriteLine($"numArabic : {numArabic}");
}


Console.Write("Введите римское число: ");
string romulNum = Console.ReadLine();
romulNum = romulNum.ToUpper();

// if (romulNum > "MMMCMXCIX") Console.WriteLine("ОШИБКА! Слишком большое число");

// IF leght string ODD -> doing even for algoritm convert romul to arabic
if (romulNum.Length % 2 == 1) romulNum = string.Concat("#" , romulNum); 

ConvertRomul2Arabic(romulNum);