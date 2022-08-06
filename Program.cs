// Ввод строки пользователем
string EnterData(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    return input;
}

// Преобразование строки в массив строк
string[] StringArray(string InputString)
{
    string[] ResultString = InputString.Split(' ');
    return ResultString;
}

// Формирование массива строк с длиной меньше ллибо равной трём символам
string[] SpecLengthElementsArray(string[] InputArray, int ElementLength)
{
    string[] ResultArray = new string[1];
    int j = 0;
    int n = InputArray.Length;
    for (int i = 0; i < n; i++)
    {
        if (InputArray[i].Length <= ElementLength)
        {
            ResultArray[j] = InputArray[i];
            Array.Resize(ref ResultArray, ResultArray.Length + 1);
            j++;
        }
        else continue;
    }
    return ResultArray;
}

string result = EnterData("Введите массив строк: ");
string[] resultString = StringArray(SpecLengthElementsArray(result));

Console.WriteLine("Итоговый массив: [" + String.Join(", ", resultString) + "]");