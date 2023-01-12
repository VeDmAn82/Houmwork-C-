// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

Console.Write("Enter length Massive - ");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber || length <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[] array = GetRandomArray(length);
PrintArray(array);
Console.WriteLine();
Console.Write("Sum Odd Position Numbers: ");
Console.WriteLine(GetSumOddPositionNumbersInArray(array));

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}

int GetSumOddPositionNumbersInArray(int[] array)
{
    int sumOddPositionNumbers = 0;
    for (int i = 1; i < array.Length; i = i + 2) 
    {
        sumOddPositionNumbers += array[i];
    }
    return sumOddPositionNumbers;
}

void PrintArray(int[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");       
    }
    Console.Write("]");
}