//Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран. Сделать через функции.
//1, 2, 5, 7, 19, 6, 7, 8



int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int num1 = Prompt("Задайте нижний предел чисел массива: ");
int num2 = Prompt("Задайте верхний предел чисел массива: ");

//int CreateArray(int num1, int num2)
//{
    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(num1, num2);
        Console.Write($"{array[i]} ");
    }
   // return array;
//}
Console.WriteLine(array);