int m = 5; // количество строк
int n = 7; // количество столбцов

double[,] matrix = new double[m, n]; // создание массива

Random random = new Random();

// заполнение массива случайными числами
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.NextDouble() * 10;
    }
}

// вывод массива на экран с цветовой разметкой
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.ForegroundColor = (ConsoleColor)((i * n + j) % 16); // выбираем цвет в зависимости от позиции в массиве
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
