//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

class Program
{
    public static bool IsPalindromicNumber (int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{number} is less than zero!");
        }

        int numberTemp = number;

        int value;

        int numberRevers = 0;

        while (numberTemp > 0)
        {
            value = numberTemp % 10;
            numberRevers = numberRevers * 10 + value;
            numberTemp /= 10;
        }

        if (numberRevers == number)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPalindromicNumber(a));
    }
}    