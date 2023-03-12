
// Задаем размеры матриц
int rows1 = 3, columns1 = 3;
int rows2 = 3, columns2 = 3;

// Создаем две случайные матрицы
int[,] matrix1 = GenerateRandomMatrix(rows1, columns1);
int[,] matrix2 = GenerateRandomMatrix(rows2, columns2);

// Вычисляем произведение матриц
int[,] product = MultiplyMatrices(matrix1, matrix2);

// Выводим результат на консоль
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);

Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);

Console.WriteLine("Результат умножения матриц:");
PrintMatrix(product);


// Метод для генерации случайной матрицы
static int[,] GenerateRandomMatrix(int rows, int columns)
{
    Random random = new Random();
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(10);
        }
    }

    return matrix;
}

// Метод для умножения двух матриц
static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        throw new ArgumentException("Невозможно умножить матрицы: число столбцов первой матрицы не равно числу строк второй матрицы");
    }

    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            product[i, j] = sum;
        }
    }

    return product;
}

// Метод для вывода матрицы на консоль
static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

