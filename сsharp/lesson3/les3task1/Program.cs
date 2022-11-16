//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно 
//палиндромом. Не применять строки!
//14212 -> нет
//12821 -> да
//23432 -> да

/////////////////НЕ ПОЙМУ ЧТО С ВАЛИДАЦИЕЙ

int Prompt(string message)        //читаем число
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


bool Reverse(int number)
{
    int tempnumber = number;
    int reverse = 0;
    while (tempnumber > 0)
    {
        int lastvalue = tempnumber % 10;              //    2 4 6 4 2   - * * * * 2
        reverse = reverse * 10 + lastvalue;           //    2 * 10 + себя же   = 20
        tempnumber = tempnumber / 10;                 //    2 4 6 4
        //Console.Write($" -> {tempnumber} - {reverse}");
    }
    return number == reverse;
}


int number = Prompt("Введите ваше число: ");

bool ValidateNumber(int number)
{
    if (number < 10000 & number > 99999)
    {
        Console.Write("Ваше число не пятизначное");
        return true;
    }
    return false;
}

if (ValidateNumber(number))
{
    return;
}

//bool a = ValidateNumber(number);
Console.Write($"#{ValidateNumber(number)}");

if (Reverse(number))
{
    Console.Write("      Ваше число является палиндромом");
}
else
{
    Console.Write("       Ваше число НЕ является палиндромом");
}

