Console.WriteLine();
Console.WriteLine("Данная программа создает одномерный массив из строк.");
Console.WriteLine();
Console.Write("Задайте, пожалуйста, размер массива: ");
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
    { }
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