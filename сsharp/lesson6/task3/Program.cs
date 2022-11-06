//  Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой 
// суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[,] array2D = new int[,] {{ 1, 2, 3 }, { 3, 4, 5 }};


int [,] Print(int[,] array2D)           //принт массива
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

int MaxFirstLine(int[,] array2D)            //масксимум 1 строки
{
    int maxFirst = array2D[0,0];
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        if (maxFirst < array2D[0,j])
            maxFirst = array2D[0,j];
    }
    return maxFirst;
}


int MaxSecondLine(int[,] array2D)           //максимум 2 строки
{
    int maxSecond = array2D[1,0];
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        if (maxSecond < array2D[1,j])
            maxSecond = array2D[1,j];
    }
    return maxSecond;
}

int MinFirstColumn(int[,] array2D)          //минимум 1 столбца
{
    int minFirstCol = array2D[0,0];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (minFirstCol > array2D[i,0])
            minFirstCol = array2D[i,0];
    }
    return minFirstCol;
}

int MinSecondColumn(int[,] array2D)         //минимум 2 столбца
{
    int minSecondCol = array2D[0,1];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (minSecondCol > array2D[i,1])
            minSecondCol = array2D[i,1];
    }
    return minSecondCol;
}

int MinThirdColumn(int[,] array2D)          //минимум 3 столбца
{
    int minThirdCol = array2D[0,2];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (minThirdCol > array2D[i,2])
            minThirdCol = array2D[i,2];
    }
    return minThirdCol;
}
int SumOfMax(int maxFirstLine, int maxSecondLine)       //сумма максимумов строк
{
    int sumMax = maxFirstLine + maxSecondLine;
    return sumMax;
}

int SumOfMin(int minFirstColumn, int minSecondColumn, int minThirdColumn)       //сумма минимумов столбцов
{
    int sumMin = minFirstColumn + minSecondColumn + minThirdColumn;
    return sumMin;
}

void FinalResult(int sumOfMax, int sumOfMin)        //максималки - минималки
{
    int finalResult = sumOfMax - sumOfMin;
    Console.WriteLine($"Итоговая разность: {finalResult}");
}

Print(array2D);

int maxFirstLine = MaxFirstLine(array2D);
int maxSecondLine = MaxSecondLine(array2D);

int minFirstColumn = MinFirstColumn(array2D);
int minSecondColumn = MinSecondColumn(array2D);
int minThirdColumn = MinThirdColumn(array2D);

int sumOfMax = SumOfMax(MaxFirstLine(array2D), MaxSecondLine(array2D));
int sumOfMin = SumOfMin(MinFirstColumn(array2D), MinSecondColumn(array2D), MinThirdColumn(array2D));


Console.WriteLine();
Console.WriteLine($"Сумма максимумов строк = {sumOfMax}");
Console.WriteLine($"Сумма минимумов столбцов = {sumOfMin}");
FinalResult(sumOfMax,sumOfMin);
