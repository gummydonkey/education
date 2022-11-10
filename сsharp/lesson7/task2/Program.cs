using System;
/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    
}

void FindFromArray(int[,] array, int n, int m)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (n - 1 == i && m - 1 == j) Console.WriteLine($"пыщ {array[i, j]}");
        }
    }
}

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int n = Prompt("В какой строке будем искать?: ");
int m = Prompt("А столбике?: ");
FindFromArray(array, n, m);
Console.WriteLine();

