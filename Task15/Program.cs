// Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Введите число: ");
int numberIn = Convert.ToInt32(Console.ReadLine());

bool WeekDay(int numberIn)
{
    if(numberIn == 6 || numberIn == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool result = WeekDay(numberIn);

if(result == true)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Не выходной");
}
