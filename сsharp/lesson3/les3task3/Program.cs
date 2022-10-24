//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
// слишком просто
int Prompt(string message)        //читаем число
{
    System.Console.Write("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("Введите ваше число: ");
int i = 1;
while (i <= number)
{
    System.Console.Write($"{i*i*i} ");
    i++;
}