// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

Console.Write("Enter length Massive: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);

if (!isNumber || num <= 0)
{
    Console.WriteLine("Is not valid");
    return;
}

PrintArray(GetArray(num));

int[] GetArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");       
    }
    Console.Write("]");
}
