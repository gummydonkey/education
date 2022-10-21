//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не применять строки!
//14212 -> нет
//12821 -> да
//23432 -> да


int Prompt(string message)
{
    System.Console.Write("Введите пятизначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = Prompt("Введите ваше число: ");
bool ValidateNumber(int N);
{
    if (N < 10000 || N > 99999)
    {
        System.Console.Write("Ваше число не пятизначное");
        return false;
    }
    return true;
}

/*if (!ValidateNumber(N))
{
    return;
}
else if (N % 10 == N / 10000 && N / 1000 == N / 10) ;
{    
    Console.Write("Ваше число asdasе");
}*/
int N = Prompt("Введите ваше число: ");
int Oldn = N;
int Newn = 0;
if (ValidateNumber(N))
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


