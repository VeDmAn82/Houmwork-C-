// Задача 56. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов

Console.Write("Введите размерность m: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите размерность n: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber1 || !isNumber2 || n <= 0 || m <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[,] array = CreateRandomArray(m, n);
Console.WriteLine();
Print2DArray(array);
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой элементов: {GetMinSumStringArray(array)}");

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int GetMinSumStringArray(int[,] array)
{
    int[] sumString = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumString[i] += array[i, j]; 
        }
    }

    int index = 0;
    int minSum = sumString[0];
    for (int i = 1; i < sumString.Length; i++)
    {
        if (minSum > sumString[i])
        {
            minSum = sumString[i];
            index = i;
        }
    }
    return index + 1;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

