/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30      */

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int PrintSum(int m, int n)
{
    if (n < m) return 0;
    else return n + PrintSum(m ,(n - 1));
}


int m = Prompt("Введите ваше число M: ");
int n = Prompt("Введите ваше число N: ");
Console.WriteLine(PrintSum(m, n));