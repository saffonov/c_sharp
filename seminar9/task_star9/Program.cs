// Задача со звездочкой: Пользователь вводит скобочные последовательности. 
// В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, 
// составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

void CheckUserLine(string usLine)
{
    int ckeck1 = 0; //{}
    int ckeck2 = 0; //()
    int ckeck3 = 0; //[]

    foreach (var item in usLine)
    {
        switch (item)
        {
            case '{':
               ckeck1++;
               break;
            case '}':
               ckeck1--;
               break;

            case '(':
               ckeck2++;
               break;
            case ')':
               ckeck2--;
               break;               

            case '[':
               ckeck3++;
               break;
            case ']':
               ckeck3--;
               break;
            default:
                break;
        }
        // Console.WriteLine($"ckeck1= {ckeck1} , ckeck2= {ckeck2} , ckeck3= {ckeck3}");        
    }
    if ((ckeck1 == 0)&&(ckeck2 == 0)&&(ckeck3 == 0)) Console.WriteLine($"Status correct");
    else Console.WriteLine($"Status incorrect");
}



Console.WriteLine("Enter []");
string userLine = Console.ReadLine();
CheckUserLine(userLine);
