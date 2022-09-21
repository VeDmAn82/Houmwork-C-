// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число M: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите число N: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber1 || !isNumber2 || m <= 0 || n <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int GetAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return GetAkkermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return GetAkkermanFunction(m - 1, GetAkkermanFunction(m, n - 1));
    }
    return 0;
}
Console.WriteLine(GetAkkermanFunction(m, n));