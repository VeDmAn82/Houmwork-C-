// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
Console.Write("Quantity Even Numbers: ");
Console.WriteLine(GetCountEvenNum(array));

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int GetCountEvenNum(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");       
    }
    
}