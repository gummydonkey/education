//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не применять строки!
//14212 -> нет
//12821 -> да
//23432 -> да


int Prompt(string message)        //читаем число
{
    System.Console.Write("Введите пятизначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)               // проверка на диапазон чисел. не до конца понятно как рабоает
{
    if (number < 10000 && number > 99999)
    {
        System.Console.Write("Ваше число не пятизначное");
        return true;
    }
    return false;
}

bool IsAPalindrome(int number)
{
    int rev = 0;
    int tempnumber = number;
    while (number > 0)
    {
        int value = number % 10;
        int rev = rev * 10 + value;
        int number = number / 10;
    }
    return tempnumber == rev;
}
int number = Prompt("Введите ваше число: ");   //присваиваем число


if (ValidateNumber(number))    // копипаст (хз) но без нее не работает???
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

/*
int Oldn = N;
int Newn = 0;
if (!ValidateNumber(N))
{
    return;
}
while (N > 0)
{
    int Value = N % 10;
    Newn = Newn * 10 + Value;
    N = N / 10;
}
if (Oldn == Newn)
{
    System.Console.WriteLine("asdasd");
}
*/


