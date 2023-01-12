// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4

Console.Write("Введите размерность m: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите размерность n: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber1 || !isNumber2 || n <= 0 || m <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[,] matrix = new int[m, n];
if (matrix.GetLength(0) != matrix.GetLength(1))
{
    Console.WriteLine("Массив не квадратный");
    return;
}
FillMatrix(matrix);
Print2DArray(matrix);

void FillMatrix(int[,] matrix)
{
    int k = 1;
    int i = 0;
    int j = 0;
    while (k <= matrix.GetLength(0) * matrix.GetLength(1)) 
    {
        matrix[i, j] = k;
        k++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
