int Prompt(string message) 
{     
    Console.Write(message);     
    int number = Convert.ToInt32(Console.ReadLine());     
    return number; 
}  

bool ValidateCoords (int Quarter) 
{     
    if (Quarter > 4 && Quarter < 1)     
    {         
        Console.WriteLine("Вы ввели неправильную четверть");         
        return false;     
    }     
    return true; 
    } 
string GetCoords (int Quarter) 
{     
    switch (Quarter)     
{         
    case 1 :         
    return "x > 0 и y > 0";         
    case 2 :         
    return "x < 0 и y > 0";         
    case 3:         
    return "x < 0 и y < 0";         
    default:         
    return "x > 0 и y < 0";      
    } 
}  

int Quarter = Prompt ("Введите номер четверти: ");
if (!ValidateCoords(Quarter))
{
    return;
}
System.Console.WriteLine(GetCoords(Quarter));
