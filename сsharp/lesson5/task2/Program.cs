//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int ArraySize()                 // генератор размера массива
{
    Random random = new Random();
    int arr_size = random.Next(1,10);
    return (arr_size);
}

int[] FillArr(int arr_size)                     //создаем и заполняем массив случайными числа с размером заданным выше
{
    int[] array = new int[arr_size];
    Random random = new Random();
    Console.WriteLine("Сумма элементов массива:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-50, 50);
        Console.Write($"{array[i]}\t");

    }
    return array;
}

void SummNotEvenI(int [] array)             // числа с четными индексами игнорируются, НЕчётными плюсуются в сумму
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        sum += array[i];
        
    }
    Console.WriteLine();
    Console.WriteLine($"стоящих на нечётных позициях равна: {sum}");
}

int arr_size = ArraySize();
int [] array = FillArr(arr_size);
SummNotEvenI(array);