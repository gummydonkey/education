//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
//452 -> 11
//82 -> 10
//9012 -> 12

System.Console.WriteLine("Нахождение суммы цифр Вашего числа");
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите ваше число: ");

int SummNum(int number)
{
    int summ = 0;
    while (number > 0)
    {
        int curr = number % 10;
        number = number / 10;
        summ = curr + summ;
    }
    return summ;
}

int result = SummNum(number);
Console.WriteLine($"Сумма цифр равна: {SummNum(number)}");
