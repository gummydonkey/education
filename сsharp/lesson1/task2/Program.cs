//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) 
{
    max = b;
}
if (c > max)
{
    max = c;
 }
Console.WriteLine($"Максимальное число: {max}");