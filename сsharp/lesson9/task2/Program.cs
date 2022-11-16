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
    if (m > n) return m;
    PrintSum(m + (m + 1), n);
}


int m = 3;//Prompt("Введите ваше число M: ");
int n = 9;//Prompt("Введите ваше число N: ");
//PrintSum(m, n);
//int res = PrintSum(m, n);
System.Console.WriteLine(PrintSum(m, n));