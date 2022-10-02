//
string[] GetArray(int m, int n) // m - number of string; n - number char in string
{
    char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    string[] result = new string[m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           int num_letters = new Random().Next(0, letters.Length - 1);
           result[i] += letters[num_letters]; 
        }    
    }
    return result;
}


Console.WriteLine("START");

Console.Write("Введите количество строк:");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество символов:");
int n = int.Parse(Console.ReadLine());

string[] arr = GetArray(m, n);
Console.WriteLine("Исходный массив");
Console.Write(String.Join(", ", arr));
//Console.Write(String.Join(", ", GetRNDarray(n, A, B)));



