/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

*/

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int [,] CreateArray(int m, int n)
{
    int [,] arr = new int[m, n];
    Random rnd = new Random();
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    return arr;
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

void MediumColumn(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j];
        }
        Console.Write($"{sum}\t");

    }
}

System.Console.WriteLine();
int m = Prompt("Сколько строк будет в массиве?: ");
int n = Prompt("Столбиков?: ");
System.Console.WriteLine();
CreateArray(m,n);
int [,] arr = CreateArray(m,n);
PrintArray(arr);
System.Console.WriteLine();
MediumColumn(arr);
