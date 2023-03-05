Console.Write("Введите количество чисел Фибоначчи, которые нужно вывести: ");
int n = int.Parse(Console.ReadLine()?? "0");

int a = 0, b = 1, c;
Console.Write($"{a} {b} ");

for (int i = 2; i < n; i++)
{
    c = a + b;
    Console.Write($"{c} ");
    a = b;
    b = c;
}

