
// создаем массив из 10 вещественных чисел
double[] array = new double[] { 3.14, 2.71, 1.618, 0.577, 1.414, 0.866, 2.718, 1.732, 1.303, 0.693 };

// инициализируем переменные для хранения минимального и максимального значений
double min = double.MaxValue;
double max = double.MinValue;

// находим минимальный и максимальный элементы массива
foreach (double element in array)
{
    if (element < min)
    {
        min = element;
    }
    if (element > max)
    {
        max = element;
    }
}

// находим разницу между максимальным и минимальным элементами
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");

// сортируем массив методом вставки
for (int i = 1; i < array.Length; i++)
{
    double key = array[i];
    int j = i - 1;

    while (j >= 0 && array[j] > key)
    {
        array[j + 1] = array[j];
        j = j - 1;
    }

    array[j + 1] = key;
}

// выводим отсортированный массив на экран
Console.WriteLine("Отсортированный массив:");
foreach (double element in array)
{
    Console.Write(element + " ");
}
