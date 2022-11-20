/*
 Задайте значения M и N. Напишите программу, которая выведет все чётные 
 натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"           */

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int PrintNum(int m, int n)
{
    if (m == n) return m;

    if (m % 2 == 0)
    {
        PrintNum(m + 2, n);
        System.Console.WriteLine(m);
    }
    else
    {
        PrintNum(m + 1, n);
        System.Console.WriteLine(m);
    }
}

int m = 3;//Prompt("Введите ваше число M: ");
int n = 9;//Prompt("Введите ваше число N: ");
PrintNum(m, n);

