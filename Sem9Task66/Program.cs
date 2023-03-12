Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

int sum = SumNaturalNumbers(m, n);

Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1} равна {2}", m, n, sum);


static int SumNaturalNumbers(int start, int end)
{
    if (start > end)
    {
        return 0;
    }

    return start + SumNaturalNumbers(start + 1, end);
}
