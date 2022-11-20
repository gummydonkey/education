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

int A(int n, int m)
{
    if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
    if (n == 0) return m + 1;
    if (m == 0) return A(n - 1, m);
    return A(n - 1, A(n, m - 1));
}


int n = Prompt("Введите ваше число N: ");
int m = Prompt("Введите ваше число M: ");

A(n,m);
Main(n,m);

void Main(int n, int m)
{
    Console.WriteLine(A(n, m));  // 2.5
    //Console.WriteLine(A(1, 2));
}