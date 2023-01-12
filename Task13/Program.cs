// Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Введите число: ");
int numIn = Convert.ToInt32(Console.ReadLine());
numIn = Math.Abs(numIn);
int resultDigit = FindThirdDigit(numIn);

int FindThirdDigit(int numIn)
{
    int count = 0;
    while(numIn > 0)
    {
        numIn = numIn / 10;
        count++;
    }
    return count;
}

if(resultDigit > 2)
{
    int numD = Convert.ToInt32(Math.Pow(10, resultDigit - 3));
    int numT = numIn / numD;
    int thirdDigit = numT % 10;
    Console.WriteLine($"Третья цифра {thirdDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
  