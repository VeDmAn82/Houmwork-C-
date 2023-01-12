// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Write("Введите число: ");
bool isNum_A = int.TryParse(Console.ReadLine(), out int a);

if (!isNum_A || a < 0)
{
    Console.WriteLine("Is not valid");
    return;
}

int FindSumDigit(int b)
{
    int sum = 0;
    int count = 0;
    while(b > 0)
    {
        sum = sum + b % 10;
        b = b /10;
        count++;
    }
    return sum;
}
Console.Write(FindSumDigit(a));