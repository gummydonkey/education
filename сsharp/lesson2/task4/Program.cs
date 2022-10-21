//Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

System.Console.Write("Введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 ^ day > 7)
{
    Console.Write("В неделе 7 дней!");
}
else if (day < 6)
{
    Console.WriteLine("Увы, сегодня НЕ выходной."); 
}
else
{
    Console.WriteLine("Cегодня ВЫХОДНОЙ.");  
}