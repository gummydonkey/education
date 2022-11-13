/*
Задайте двумерный массив. Напишите программу, которая упорядочивает 
по убыванию элементы каждой строки двумерного массива.
*/



int [,] CreateArray()
{
    Random rnd = new Random();
    int [,] arr = new int[rnd.Next(3, 5), rnd.Next(3, 5)];
    
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    return arr;
}

void PrintArr(int [,] arr)
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


CreateArray();
int[,] arr = CreateArray();
PrintArr(arr);
System.Console.WriteLine();