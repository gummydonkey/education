﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введите 3ех значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 & a < 1000)
{
    int x = (a % 100)/10;
    Console.WriteLine($"Вторая цифра вашего числа: {x}");
}
else
    Console.WriteLine("Ваше число не трех значное");
