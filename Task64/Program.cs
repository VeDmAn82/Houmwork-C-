// Задача 64. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

Console.Write("Введите число M: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите число N: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber1 || !isNumber2 || m <= 0 || n <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[] array = new int[n - m + 1];
int i = 0;

int[] GetNumbers(int m, int n)
{
    if (m <= n)
    {
        array[i] = m;
        m++;
        i++;
        GetNumbers(m, n);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");   
    }
    Console.WriteLine();
}

PrintArray(GetNumbers(m, n));
