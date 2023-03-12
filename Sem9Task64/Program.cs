Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(1, n);


static void PrintNumbers(int start, int end)
{
    if (start <= end)
    {
        Console.WriteLine(start);
        PrintNumbers(start + 1, end);
    }
}

