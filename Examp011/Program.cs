﻿//Задача 38: 
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] d = new int[30];
            int max=0, min=100;
            for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(100);
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }
           
               for (int i = 0; i < d.Length; i++) Console.Write(" "+d[i]);//выводим массив
               Console.WriteLine();
                 Console.WriteLine("max:  " + max);
                 Console.WriteLine("min  " +min);
                 Console.WriteLine("Разница максимального и минимального:  "+(max - min));
                Console.ReadKey();
        }
    }