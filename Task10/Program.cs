// Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if((numA / 100 > 0) && (numA / 1000 == 0))
{
    int result = FindSecondDigit(numA);
    int FindSecondDigit(int numA)
    {
        int secondNumber = numA % 100;
        int result = secondNumber / 10;
        return result;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число НЕ трехзначное или отрицательное!");
}
