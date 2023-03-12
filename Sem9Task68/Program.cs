Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int result = Ackermann(m, n);

Console.WriteLine($"Значение функции Аккермана для m={m} и n={n}: {result}");

static int Ackermann(int m, int n, int result = 0)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1, result);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1, result), result);
}
