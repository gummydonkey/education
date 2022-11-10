﻿/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double [,] CreateArray(int m, int n)
{
    double [,] arr = new double[m, n];
    Random rnd = new Random();
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
        }
    }
    return arr;
}

void PrintArr(double [,] arr, int m, int n)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
    
}

Console.WriteLine();
int m = Prompt("Количество строк массива: ");
int n = Prompt("Колличество столбцов массива: ");
Console.WriteLine();
double [,] arr = CreateArray(m, n);
CreateArray(m, n);
PrintArr(arr, m, n);
Console.WriteLine();




