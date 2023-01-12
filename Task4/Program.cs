// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.WriteLine("Введите три числа ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if(numB > max)
{
    max = numB;
}
if(numC > max)
{
    max = numC;
}
int result = max;
Console.Write("max = ");
Console.WriteLine(result);