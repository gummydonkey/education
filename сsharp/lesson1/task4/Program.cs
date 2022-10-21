//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int value = 2;
if (N >= 2)
    while (value <= N)
{
    Console.Write($"{value};");
    value = value + 2;
}
else
    Console.WriteLine($"Число {N} не имеет четных чисел от 1 до {N}");