//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно 
//палиндромом. Не применять строки!
//14212 -> нет
//12821 -> да
//23432 -> да


int Prompt(string message)        //читаем число
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 10000 && number > 99999)
    {
        System.Console.Write("Ваше число не пятизначное");
        return true;
    }
    return false;
}

int Reverse(int number)
{
    int reverse = 0;
    while (number > 0)
    {
        int value = number % 10;
        reverse = reverse * 10 + value;
        int tempnumber = number / 10;
        Console.Write($"1 -> {tempnumber} - {reverse}");
    }
    return reverse;
}

bool IsAPalindrome(int number)
{

    if (number == Reverse(number))
    {
        Console.WriteLine(Reverse(number));
        Console.WriteLine(number);
        return number == Reverse(number);
    }
    else
    {
        Console.WriteLine(Reverse(number));
        Console.WriteLine(number);
        return false;
        
    }
    


    // почему вытягиваем Reverse(number) мы ведь возвращали reverse. 
    //Или мы тут упоминаем метод как мы его обозвали выше? 
    //т.к. вохвращает значение которое записывается в number этого метода?
}



int number = Prompt("Введите ваше число: ");


if (ValidateNumber(number))
{
    return;
}

if (IsAPalindrome(number))
{
    Console.Write("Ваше число является палиндромом");
}
else
{
    Console.Write("Ваше число НЕ является палиндромом");
}

