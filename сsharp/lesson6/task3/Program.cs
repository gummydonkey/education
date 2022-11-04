//  Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой 
// суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[,] array2D = new int[,] {{ 1, 2, 3 }, { 3, 4, 5 }};


int [,] Print(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
    return array2D;
}

int maxFirstLine(int[,] array2D)
{
    int maxFirst = array2D[0,0];
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        if (maxFirst < array2D[0,j])
            maxFirst = array2D[0,j];
    }
    Console.WriteLine($"{maxFirst} maxFL");
    return maxFirst;
}


int maxSecondLine(int[,] array2D)
{
    int maxSecond = array2D[1,0];
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        if (maxSecond < array2D[1,j])
            maxSecond = array2D[1,j];
    }
    Console.WriteLine($"{maxSecond} maxSL");
    return maxSecond;
}

int minFirstColumn(int[,] array2D)
{
    int minFirstCol = array2D[0,0];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (minFirstCol > array2D[i,0])
            minFirstCol = array2D[i,0];
    }
    Console.WriteLine($"{minFirstCol} min1");
    return minFirstCol;
}

int minSecondColumn(int[,] array2D)
{
    int minSecondCol = array2D[0,1];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (minSecondCol > array2D[i,1])
            minSecondCol = array2D[i,1];
    }
    Console.WriteLine($"{minSecondCol} min2");
    return minSecondCol;
}

int minThirdColumn(int[,] array2D)
{
    int minThirdCol = array2D[0,2];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (minThirdCol > array2D[i,2])
            minThirdCol = array2D[i,2];
    }
    Console.WriteLine($"{minThirdCol} min3");
    return minThirdCol;
}
void SumOfMax(int maxFirstLine, int maxSecondLine)
{
Console.WriteLine($"{maxFirstLine(array2D)} + {maxSecondLine(array2D)}");
}
Print(array2D);
maxFirstLine(array2D);
maxSecondLine(array2D);
minFirstColumn(array2D);
minSecondColumn(array2D);
minThirdColumn(array2D);
Console.WriteLine();
Console.WriteLine(SumOfMax(maxFirstLine));

