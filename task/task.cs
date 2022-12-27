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