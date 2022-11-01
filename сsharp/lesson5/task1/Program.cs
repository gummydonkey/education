using System;
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int ArraySize()                     // генератор размера массива
{
    Random random = new Random();
    int arr_size = random.Next(1, 10);
    return (arr_size);
}

int[] FillArr(int arr_size)         //создаем и заполняем массив случайными числа с размером заданным выше
{
    int[] array = new int[arr_size];
    Random random = new Random();
    Console.WriteLine("Четных чисел в данном массиве:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 999);
        Console.Write($"{array[i]}\t");

    }
    return array;
}

void Even(int [] array)      // находим четные и сразу выводим на экран
{
    int value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            value++;
    }
    Console.WriteLine();
    Console.Write($"Всего {value}. ");
    
}

int arr_size = ArraySize();     // оказывается присваивая функцию в переменную она еще и вызывается сразу
int [] array = FillArr(arr_size);
Even(array);
