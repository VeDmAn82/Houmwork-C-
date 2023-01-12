// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем

Console.WriteLine("Enter k1: ");
bool isK1 = double.TryParse(Console.ReadLine(), out double k1);

Console.WriteLine("Enter b1: ");
bool isB1 = double.TryParse(Console.ReadLine(), out double b1);

Console.WriteLine("Enter k2: ");
bool isK2 = double.TryParse(Console.ReadLine(), out double k2);

Console.WriteLine("Enter b2: ");
bool isB2 = double.TryParse(Console.ReadLine(), out double b2);

Console.WriteLine("");

if (!isK1 || !isB1 || !isK2 || !isB2)
{
    Console.WriteLine("Is not valid");
    return;
}
if(k1 == k2)
{
    Console.WriteLine("Parallels lines");
    return;
}

double[] array = GetIntersectionPointLines(k1, b1, k2, b2);
Console.Write($"Intersection Point Lines: [{array[0]}; {array[1]}] ");

double[] GetIntersectionPointLines(double k1, double b1, double k2, double b2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * array[0] + b1;
    return array;
}

