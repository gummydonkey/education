//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int[] array = { 3, 7, 22, 2, 78};

int MinArr(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    return min;
}

int MaxArr(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
    }
    return max;
}

void Diff(int min, int max)
{
    int different = max - min;
    Console.WriteLine($"Разность между максимальным и минимальным элементом массива равна: {different}");
}

int min = MinArr(array);
int max = MaxArr(array);
Diff(min, max);


