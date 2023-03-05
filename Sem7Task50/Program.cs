// Создаем двумерный массив и заполняем его числами Фибоначчи
int[,] arr = new int[10, 10];
arr[0, 0] = 1;
arr[0, 1] = 1;
for (int i = 2; i < 10; i++)
{
    arr[0, i] = arr[0, i - 1] + arr[0, i - 2];
}
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        arr[i, j] = arr[i - 1, j] + arr[i, j - 1];
    }
}
//Выводим массив в консоль
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.ForegroundColor = (ConsoleColor)(i % 16 + 1);
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

// Вводим позиции элемента
Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine());

// Проверяем, что позиции в массиве существуют
if (row >= 0 && row < 10 && col >= 0 && col < 10)
{
    int num = arr[row, col];
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Значение элемента: {num}");
    Console.ResetColor();
}
else
{
    Console.WriteLine("Такого элемента нет.");
}
