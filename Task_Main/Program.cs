// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] workArray = FillArray();
string[] resultArray = GenerateNewArray(workArray);
string firstArray = PrintArray(workArray);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);

string[] FillArray()
{
    Console.WriteLine("Введите данные через пробел или запятую. По окончании ввода нажмите Enter: ");
    string? enterElements = Console.ReadLine();
    if (enterElements == null) { enterElements = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = enterElements.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}

string PrintArray(string[] workArray)
{
    string stringArray = "[";
    for (int i = 0; i < workArray.Length; i++)
    {
        if (i == workArray.Length - 1)
        {
            stringArray += $"\"{workArray[i]}\"";
            break;
        }
        stringArray += ($"\"{workArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountStringElements(string[] workArray)
{
    int counter = 0;
    foreach (string element in workArray)
    {
        if (element.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] GenerateNewArray(string[] workArray)
{
    int resultArrayLength = CountStringElements(workArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string element in workArray)
    {
        if (element.Length <= 3)
        {
            resultArray[i] = element;
            i++;
        }
    }
    return resultArray;
}