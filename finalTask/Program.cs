//Из массива строк формирует массив с длинной строк 3 и миньше.

string GenerateString()
{
    Random rnd = new Random();
    int number = rnd.Next();
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
        Console.WriteLine(arr[i]);
    }
}
