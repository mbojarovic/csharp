﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("максимальное минимальное число из 2 цифр.");
Console.Write("введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine("максимальное число " + firstNumber);
    Console.WriteLine("минимальное число " + secondNumber);
}
else
{
    if (secondNumber > firstNumber)
    {
        Console.WriteLine("максимальное число " + secondNumber);
        Console.WriteLine("минимальное число " + firstNumber);
    }
    else
    {
        Console.WriteLine("это одинаковые числа!");
    }
}