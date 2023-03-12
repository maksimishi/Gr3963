
// Генерируем случайный двумерный массив
int[,] arr = GenerateRandomArray(3, 3, 1, 20);

// Сохраняем исходный массив
int[,] originalArray = (int[,])arr.Clone();

// Проходим по каждой строке массива
for (int i = 0; i < arr.GetLength(0); i++)
{
    // Сортируем элементы строки по убыванию
    SortDescending(arr, i);
}

// Выводим исходный массив
Console.WriteLine("Исходный массив:");
PrintArray(originalArray);

// Выводим отсортированный массив
Console.WriteLine("Отсортированный массив:");
PrintArray(arr);


// Метод для генерации случайного двумерного массива
static int[,] GenerateRandomArray(int rows, int cols, int minValue, int maxValue)
{
    Random random = new Random();
    int[,] arr = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = random.Next(minValue, maxValue);
        }
    }
    return arr;
}

// Метод для сортировки элементов строки по убыванию
static void SortDescending(int[,] arr, int row)
{
    int n = arr.GetLength(1);
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (arr[row, j] > arr[row, i])
            {
                int temp = arr[row, i];
                arr[row, i] = arr[row, j];
                arr[row, j] = temp;
            }
        }
    }
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

