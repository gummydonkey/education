//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

System.Console.WriteLine("Возведение числа А в степень В");
int Prompt(string message)        //читаем число
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("Введите ваше число A: ");
int sqr = Prompt("Введите ваше число B: ");

int Sqr(int number)
{
    int res = 1;
    int i = 0;
    while (i < sqr)
    {
        res = number * res;    
        i++;
    }

    return res;                             
}

System.Console.WriteLine(Sqr(number));
