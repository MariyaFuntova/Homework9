Console.Write("Введите натуральное число больше 1: ");
int N = Convert.ToInt32(Console.ReadLine());

void NumberCounter (int N)
{
    if (N == 0) return;
    Console.WriteLine($"{N} ");
    NumberCounter(N - 1);
}

NumberCounter(N);