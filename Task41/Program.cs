// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Write("Enter length Massive: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int M);

if (!isNumber)
{
    Console.WriteLine("Is not valid");
    return;
}

int[] array = GetArray(M);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.Write("Volume greater Zero numbers: ");
Console.Write(GetVolumeGreaterZeroNumbers(array));

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int GetVolumeGreaterZeroNumbers(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

void PrintArray(int[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");       
    }
    Console.Write("]");
}
