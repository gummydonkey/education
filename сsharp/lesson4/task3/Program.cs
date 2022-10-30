//Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран. Сделать через функции.
//1, 2, 5, 7, 19, 6, 7, 8

/*
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int num1 = Prompt("Задайте нижний предел чисел массива: ");
int num2 = Prompt("Задайте верхний предел чисел массива: ");
*/
//победа

void CreateArray()
{
    int [] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(1, 100);
        Console.Write($"{array[i]}   ");
    }
    //Console.WriteLine(array);
}

CreateArray();
//var stringarr = CreateArray().ToString();
//var stringarr = stringarr.Join(" ", array);
//Console.WriteLine(CreateArray(array));

    
