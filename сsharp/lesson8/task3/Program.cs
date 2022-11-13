/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

int[,] CreateArrayA()
{
    Random rnd = new Random();
    int[,] arrA = new int[rnd.Next(3, 4), rnd.Next(3, 4)];  // (включительно, исключительно)
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrA.GetLength(1); j++)
        {
            arrA[i, j] = rnd.Next(0, 5);
        }
    }
    return arrA;
}

int[,] CreateArrayB()
{
    Random rnd = new Random();
    int[,] arrB = new int[rnd.Next(3, 4), rnd.Next(3, 4)];
    for (int i = 0; i < arrB.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            arrB[i, j] = rnd.Next(0, 5);
        }
    }
    return arrB;
}


void PrintArr(int[,] arrA, int[,] arrB)
{
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrA.GetLength(1); j++)
        {
            Console.Write($"{arrA[i, j]}\t");
        }
        Console.Write($"-       ");
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            Console.Write($"{arrB[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void ArrResult(int[,] arrA, int[,] arrB)
{
    int[,] arrRes = new int[arrA.GetLength(0), arrA.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrA.GetLength(1); j++)
        {
            arrRes[i, j] = arrA[i, j] * arrB[i, j];
            Console.Write($"{arrRes[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] arrA = CreateArrayA();
int[,] arrB = CreateArrayB();
PrintArr(arrA, arrB);
System.Console.WriteLine();
ArrResult(arrA,arrB);