//Из массива строк формирует массив с длинной строк 3 и меньше.

string GenerateString()
{
    Random rnd = new Random();
    int number = rnd.Next(10, 2000);
    int rndString = number;
    return rndString.ToString();
}
void FillStringArray(string[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = GenerateString();
    }
}
void PrintArray(string[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string[] array = new string[10];

FillStringArray(array);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write($"{array[i]} ");
    }
}