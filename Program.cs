// Ввод строки пользователем и ее преобразование в массив строк
string[] StringArray(string message)
{
    Console.WriteLine(message);
    string InputString = Console.ReadLine();
    string[] ResultString = InputString.Split(' ');
    return ResultString;
}

// Формирование массива строк с длиной меньше либо равной заданному количеству символов
string[] SpecLengthElementsArray(string[] InputArray, int ElementLength)
{
    string[] ResultArray = new string[0];
    int j = 0;
    int n = InputArray.Length;

    for (int i = 0; i < n; i++)
    {
        if (InputArray[i].Length <= ElementLength)
        {
            Array.Resize(ref ResultArray, ResultArray.Length + 1);
            ResultArray[j] = InputArray[i];
            j++;
        }
        else continue;
    }
    return ResultArray;
}

// Ввод массива строк
string[] InputStringArray = StringArray(("Введите массив строк: "));

Console.WriteLine();
Console.WriteLine("Начальный массив: [" + String.Join(", ", InputStringArray) + "]");

// Формирование нового массива с длиной элементов меньше либо равной 3 символа из исходного массива
string[] ResultStringArray = SpecLengthElementsArray(InputStringArray, 3);

Console.WriteLine();
Console.WriteLine("Итоговый массив: [" + String.Join(", ", ResultStringArray) + "]");