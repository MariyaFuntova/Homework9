int GetUserInt(string messege)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write (messege);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int result(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return result(m - 1, 1);
    }
    else
    {
        return result(m - 1, result(m,n - 1));
    }
}

int m = GetUserInt("Введите число M: ");
int n = GetUserInt("Введите число N: ");
int Akkerman = result(m,n);
Console.WriteLine($"Функция Аккермана = {Akkerman} ");
