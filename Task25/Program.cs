// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Write("Введите число: ");
bool isNumber_A = int.TryParse(Console.ReadLine(), out int numA);

Console.Write("Введите степень числа: ");
bool isNumber_B = int.TryParse(Console.ReadLine(), out int numB);

if (!isNumber_A || !isNumber_B || numA < 0 || numB < 0)
{
    Console.WriteLine("Is not valid");
    return;
}

int degree = FindDegree(numA, numB);

int FindDegree(int x, int y)
{
    int result = x;
    int i = 1;
    while(i < y)
    {
        result = result * x;
        i++;
    }
    return result;
}
Console.Write(degree);