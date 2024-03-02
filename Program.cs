Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];
void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите { i + 1} элемент массива");
    stringArray[i] = Console.ReadLine();
    }
}
string[] sym(string[] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 2)
            n++;
    }
    string[] rez = new string[n];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 2)
        {
            rez[j] = stringArray[i];
            j++;
        }
    }
    return rez;
}
void printA(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"‘{ stringArray[i]}’, ");
}
Console.Write("]");
}
array(stringArray);
printA(sym(stringArray));