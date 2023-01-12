// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите пятизначное число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);

if (!isNumber || num <= 9999 || num > 99999)
{
    Console.WriteLine("Is not valid");
    return;
}

bool CheckPalindrome(int number)
{
    int InitialNumber = number;
    int ReverseNumber = 0;
    while (number > 0)
    {
         ReverseNumber = ReverseNumber + (number % 10);
         number = number / 10;
         ReverseNumber = ReverseNumber * 10;
    }
    ReverseNumber = ReverseNumber / 10;
    
    if (InitialNumber == ReverseNumber)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool result = CheckPalindrome(num);
if(result == true)
{
    Console.WriteLine("It is palindrome");
}
else
{
    Console.WriteLine("It is not palindrome");
}
