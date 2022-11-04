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
    Console.WriteLine($"{maxFirst} ");
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
    Console.WriteLine($"{maxSecond} ");
    return maxSecond;
}


Print(array2D);
maxFirstLine(array2D);
maxSecondLine(array2D);