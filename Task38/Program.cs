// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

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
Console.Write("Difference Max Min Numbers: ");
Console.WriteLine(GetDifferenceMaxMinNumbersInArray(array));

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

int GetDifferenceMaxMinNumbersInArray(int[] array)
{
    int result = 0;
    int minElement = array[0];
    int maxElement = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < minElement)
        {
            minElement = array[i];
        }

        if(array[i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    for (int j = 0; j < array.Length; j++) 
    {
        result = maxElement - minElement;
    }
    return result;
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