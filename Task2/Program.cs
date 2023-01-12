// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

int max = numA;

if(numB > max)
{
    max = numB;
}
else
{
    max = numA;   
}
int result = max;
Console.Write("max = ");
Console.WriteLine(result);