//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int value = a % 2;

if (value != 0)
{
    System.Console.WriteLine("{value}Число НЕ является четным");
}
else
{
    System.Console.WriteLine("Число ЯВЛЯЕТСЯ четным");
}
