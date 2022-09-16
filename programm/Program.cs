int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

string PrintArray(string[] array)
{
    string res = "[";
    for (int i = 0; i < array.Length; i++)
    {
        res = res + array[i];
        if (i < array.Length-1)
        {
            res = res + "; ";
        }
    }
    res = res + "]";
    return res;
}

string PrintArray3(string[] array)
{
    string res = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) res = res + array[i];
        if (i < array.Length-1)
        {
            res = res + "; ";
        }
    }
    res = res + "]";
    return res;
}

int size = GetNum("Введите количество строк в массиве ");
string[] array = new string[size];

Console.WriteLine("Введите массив строк:");
for (int i = 0; i < size; i++)
{
    int index = i+1;
    Console.Write("Введите " + index + "-ю строку массива:");
    array[i] = Console.ReadLine();
}

Console.WriteLine("Вы ввели массив - " + PrintArray(array));
Console.WriteLine("Массив строк длинной меньше либо равна 3 - " + PrintArray3(array));
