//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine();
int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int value = Prompt("Сколько чисел вы планируете ввести?: ");
System.Console.WriteLine();

int[] CreateArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountMeter(int[] array)
{  
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    System.Console.WriteLine();
    return count;
}


Console.WriteLine($"Подсчёт чисел больше 0");
int final_value = Convert.ToInt32(CountMeter(CreateArray(value)));
System.Console.WriteLine($"Колличество чисел больше 0 => {final_value}");
Console.WriteLine();