//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

const int x = 0;
const int y = 0;
const int z = 0;
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int [] InputPoint(int point)
{
    int [] answer = new int[3];
    answer[x] = Prompt($"Введите точку X {point}:");
    answer[y] = Prompt($"Введите точку Y {point}:");
    answer[z] = Prompt($"Введите точку Z {point}:");
    return answer;
}

double Power2(int arg)
{
    return Math.Pow(arg,2);               // Не совсем понятно квадрат чего
}

int [] p1 = InputPoint (1);
int [] p2 = InputPoint (2);

double lenght = Math.Sqrt (Power2 (p1 [x] - p2 [x]) + Power2 (p1 [y] - p2 [y]) + Power2 (p1 [z] - p2 [z]));

System.Console.WriteLine($"{lenght:f2}");