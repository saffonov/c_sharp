//
string[] GetArray(int m, int n) // m - number of string; n - number char in string
{
    char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    string[] result = new string[m];
    for (int i = 0; i < m; i++)
    {
        int num_char = new Random().Next(1, n+1);
        for (int j = 0; j < num_char; j++)
        {
           int num_letters = new Random().Next(0, letters.Length - 1);
           result[i] += letters[num_letters]; 
        }    
    }
    return result;
}

string[] GetShortArray(int m, string[] array) // m - number of short string; 
{
    string[] result = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= m)
        {
            result[j] = array[i];
            j++;
        } 
      
    }
    Array.Resize(ref result, j);
    return result;
}



Console.WriteLine("START");

Console.Write("Введите количество строк:");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество символов:");
int n = int.Parse(Console.ReadLine());

string[] arr = GetArray(m, n);
Console.WriteLine("Исходный массив");
Console.WriteLine(String.Join(", ", arr));

arr = GetShortArray(3, arr);
Console.WriteLine("Обрезанный массив");
Console.Write(String.Join(", ", arr));




