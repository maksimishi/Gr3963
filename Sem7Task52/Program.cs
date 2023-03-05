// Создаем и заполняем двумерный массив случайными числами от 0 до 99
int[,] arr = new int[10, 10];
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        arr[i, j] = rnd.Next(100);
    }
}

// Выводим массив в консоль
Console.WriteLine("Массив:");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write($"{arr[i, j],3}");
    }
    Console.WriteLine();
}

// Находим среднее арифметическое элементов в каждом столбце
double[] averages = new double[10];
for (int j = 0; j < 10; j++)
{
    int sum = 0;
    for (int i = 0; i < 10; i++)
    {
        sum += arr[i, j];
    }
    averages[j] = (double)sum / 10;
}

// Выводим средние значения в консоль
Console.WriteLine("\nСреднее арифметическое элементов в каждом столбце:");
for (int j = 0; j < 10; j++)
{
    Console.WriteLine($"Столбец {j}: {averages[j]}");
}
