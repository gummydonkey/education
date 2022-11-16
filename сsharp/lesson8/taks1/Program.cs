/*
Задайте двумерный массив. Напишите программу, которая упорядочивает 
по убыванию элементы каждой строки двумерного массива.
*/



int[,] CreateArray()
{
    Random rnd = new Random();
    int[,] arr = new int[rnd.Next(3, 5), rnd.Next(3, 5)];


    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    return arr;
}

void PrintArr(int[,] arr)
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

int[,] SortingArray(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = j +1; k < arr.GetLength(1) ; k++)
            {
                if (arr[i,j] < arr[i,k])
                {
                    temp = arr[i,j];
                    arr[i,j] = arr[i,k];
                    arr[i,k] = temp;
                }
            }
        }
    }
    return arr;
}

CreateArray();
int[,] arr = CreateArray();
PrintArr(arr);
System.Console.WriteLine();
int[,] sortingArray = SortingArray(arr);
PrintArr(arr);