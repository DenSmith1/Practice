string[] CreateArray(int count)
{
    return new string[count];
}

string[] FillArray(string[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"Введите значение для {i + 1} элемента: ");
        inputArray[i] = Console.ReadLine() ?? "0";
    }
    return inputArray;
}

int CountIndex(string[] inputArray)
{
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
            index++;
    }
    return index;
}

string[] OutputArray(string[] inputArray, string[] outputArray)
{
    int j = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[j] = inputArray[i];
            j++;
        }
    }
    return outputArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Clear();
Console.WriteLine("Программа формирования массива из строк, длина которых меньше 3х символов");
Console.Write("Введите количество строк в массиве: ");
int count = int.Parse(Console.ReadLine() ?? "0");
string[] Array = CreateArray(count);
FillArray(Array);
int index = CountIndex(Array);
string[] NewArray = CreateArray(index);
OutputArray(Array, NewArray);
PrintArray(NewArray);


