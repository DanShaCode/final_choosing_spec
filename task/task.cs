Console.WriteLine();
Console.WriteLine("Данная программа позволяет задать одномерный массив, состоящий из строк, а затем ");
Console.WriteLine("из заданного массива из строк сформировать массив из строк, длина которых меньше либо равна трем символам.");
Console.WriteLine();
Console.Write("Для начала задайте, пожалуйста, размер массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
if (arrSize <= 0)
{
    Console.WriteLine();
    Console.WriteLine("#01 Ошибка создания. Размер массива не может быть меньше, либо равен нулю.");
}
else
{
    string[] abc = new string[arrSize];
    Console.WriteLine();
    Console.WriteLine("Введите поочередно элементы массива.");
    Console.WriteLine();
    FillArr(abc);
    int cancel = CheckArr(abc);
    if (cancel == 1)
    {
        Console.WriteLine();
        Console.WriteLine("#02 Ошибка элементов. Массив не может состоять из пустых строк.");
    }
    else
    {
        Console.WriteLine();
        Console.Write("Созданный массив: ");
        PrintArr(abc);
        Console.WriteLine();
        string[] newArray = CreateNewArr(abc);
        Console.WriteLine();
        Console.Write("Сформированный массив: ");
        PrintArr(newArray);
        Console.WriteLine();
    }
}

void FillArr(string[] abc)
{
    int length = abc.Length;
    int index = 0;
    for (index = 0; index < abc.Length; index++)
    {
        Console.Write("Элемент массива: ");
        abc[index] = Console.ReadLine()!;
    }
}

int CheckArr(string[] abc)
{
    int stop = 0;
    int length = abc.Length;
    int index = 0;
    for (index = 0; index < abc.Length; index++)
    {
        if (abc[index] == String.Empty)
        {
            stop++;
            break;
        }
    }
    return stop;
}

string[] CreateNewArr(string[] abc)
{
    int count = 0;
    foreach (string element in abc)
    {
        if (element.Length <= 3) count++;
        else continue;
    }
    string[] newArray = new string[count];
    int index = 0;
    foreach (string element in abc)
    {
        if (element.Length <= 3)
        {
            newArray[index] = element;
            index++;
        }
        else continue;
    }
    return newArray;
}

void PrintArr(string[] abc)
{
    int length = abc.Length;
    int index = 0;
    for (index = 0; index < abc.Length; index++)
    {
        if (index == abc.Length - 1) Console.Write($"{abc[index]}");
        else Console.Write($"{abc[index]}, ");
    }
}