// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

Console.Write("Введите размерность m: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите размерность n: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

Console.Write("Введите размерность o: ");
bool isNumber3 = int.TryParse(Console.ReadLine(), out int o);

if (!isNumber1 || !isNumber2 || !isNumber3 || n <= 0 || m <= 0 || o <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[,,] matrix = CreateRandomMatrix3D(m, n, o);
Console.WriteLine();
Print3DArray(matrix);

int[,,] CreateRandomMatrix3D(int m, int n, int o)
{
    int[,,] matrix = new int[m, n, o];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
                while(!FindDuplicateNumbers(matrix, matrix[i, j, k]))
                {
                    matrix[i, j, k] = new Random().Next(10, 100);
                }
            }
        }
    }
    return matrix;
}

bool FindDuplicateNumbers(int[,,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == number)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
            
        }
        Console.WriteLine();
    }
}