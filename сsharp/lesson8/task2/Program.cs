/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/

Console.Clear();
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

int[] SumsRows(int[,] arr)
{
    int[] sumArr = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
            //sumArr [i] = sum;
        }
        sumArr[i] = sum;
    }
    return sumArr;
}

void MinimalRowSum(int[] sumArr)
{
    int min = sumArr[0];
    int row = 0;
    for (int i = 0; i < sumArr.Length; i++)
    {
        if (min > sumArr[i]) 
        {
            min = sumArr[i];
            row = i;
        }
    }
    Console.WriteLine($"Минимальная сумма значений в строке находится на {row +1} строке");
}

CreateArray();
int[,] arr = CreateArray();
PrintArr(arr);
System.Console.WriteLine();
string sumRows = string.Join(" ", SumsRows(arr));
Console.WriteLine($"Сумма строк {sumRows}");
System.Console.WriteLine();
int[] sumArr = SumsRows(arr);
MinimalRowSum(sumArr);
System.Console.WriteLine();