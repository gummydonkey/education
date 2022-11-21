/*
 Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29     */

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AkkFunction(int m, int n)
{
    if (m == 0) return n + 1;

    if (m == 0) return AkkFunction(m - 1, n);

    return AkkFunction(m - 1, AkkFunction(m, n - 1));

    //return AkkFunction(m, n);
}

void PrintAkkFunction(int m, int n)
{
    System.Console.WriteLine(AkkFunction(m, n));
}

int m = Prompt("Введите ваше число M: ");
int n = Prompt("Введите ваше число N: ");
PrintAkkFunction(m, n);
