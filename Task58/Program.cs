// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

Console.Write("Введите размерность первой матрицы m: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите размерность первой матрицы n: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

Console.WriteLine();

Console.Write("Введите размерность второй матрицы o: ");
bool isNumber3 = int.TryParse(Console.ReadLine(), out int o);

Console.Write("Введите размерность второй матрицы p: ");
bool isNumber4 = int.TryParse(Console.ReadLine(), out int p);

if (!isNumber1 || !isNumber2 || !isNumber3 || !isNumber4 || n <= 0 || m <= 0 || o <= 0 || p <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[,] matrix1 = CreateRandomMatrix1(m, n);
int[,] matrix2 = CreateRandomMatrix2(o, p);
Console.WriteLine();
Print2DArray(matrix1);
Console.WriteLine();
Print2DArray(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Найти произведение матриц невозможно - количество столбцов матрицы 1 не равно количеству строк матрицы 2");
    return;
}

Print2DArray(GetMatrixProduct(matrix1, matrix2));

int[,] CreateRandomMatrix1(int m, int n)
{
    int[,] matrix1 = new int[m, n];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix1;
}

int[,] CreateRandomMatrix2(int o, int p)
{
    int[,] matrix2 = new int[o, p];

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix2;
}

int[,] GetMatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
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