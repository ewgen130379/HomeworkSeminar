//Задача 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Start");
int a = 4;
int b = 3;
int c = 21;
int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max > c)
{
    max = max;
}
else
{
    max = c;
}
Console.WriteLine(max);// Вывод результата
Console.WriteLine("end");