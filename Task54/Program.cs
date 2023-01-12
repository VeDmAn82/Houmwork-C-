// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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
int[,] sortArray = GetSortStringArray(array);
Print2DArray(sortArray);
Console.WriteLine();

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[,] GetSortStringArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1) - 1); j++)
        {
            int maxNumber = j;

            for (int k = j + 1; k < array.GetLength(1); k++)      
            {
                if (array[i, maxNumber] < array[i, k])
                maxNumber = k; 
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxNumber];
            array[i, maxNumber] = temp;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}