// Задаем размеры массива
int rows = 3;
int columns = 4;

// Создаем случайный двумерный массив
int[,] arr = CreateRandomArray(rows, columns);

// Выводим массив на консоль
Console.WriteLine("Исходный массив:");
PrintArray(arr);

// Находим строку с наименьшей суммой элементов
int minSumRowIndex = FindMinSumRowIndex(arr);

// Выводим результат на консоль
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");


// Метод для создания случайного двумерного массива
static int[,] CreateRandomArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rand.Next(10);
        }
    }

    return arr;
}

// Метод для нахождения строки с наименьшей суммой элементов
static int FindMinSumRowIndex(int[,] arr)
{
    int minSum = int.MaxValue;
    int minSumIndex = -1;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumIndex = i;
        }
    }

    return minSumIndex;
}

// Метод для вывода массива на консоль
static void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
