int n = 10; // размер массива
int[] arr = new int[n]; // объявляем массив

// заполняем массив случайными числами
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    arr[i] = rnd.Next(100);
}

// выводим массив на экран
Console.WriteLine("Массив: " + string.Join(", ", arr));

// находим сумму элементов, стоящих на нечётных позициях
int sum = 0;
for (int i = 1; i < n; i += 2)
{
    sum += arr[i];
}

// выводим сумму на экран
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);

// находим все пары элементов массива и выводим на экран
Console.WriteLine("Все пары элементов массива:");
for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        Console.WriteLine(arr[i] + " " + arr[j]);
    }
}

