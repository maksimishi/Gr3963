int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void LineBuilder(int end)
{
    for (int i = 1; i <= end; i++)
    {
        Console.Write($"{i}\t");
    }

    Console.WriteLine();

    for (int i = 1; i <= end; i++)
    {
        Console.Write($"{Math.Pow(i, 2)}\t");
    }
}

int N = ReadInput("Введите конечное число:.. ");
LineBuilder(N);