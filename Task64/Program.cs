﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalNumber(number, count);

void NaturalNumber(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalNumber(n, count + 1);
        Console.Write(count + " ");
    }
}
