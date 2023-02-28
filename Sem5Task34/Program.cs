        const int n = 10;
        const int minVal = 100;
        const int maxVal = 999;
        int[] arr = new int[n];
        Random rand = new Random();

        // Заполнение массива случайными числами
        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(minVal, maxVal + 1);
        }

        // Вывод массива на экран
        Console.WriteLine("Массив:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        // Сортировка пузырьком
        int temp;
        bool isSorted;
        DateTime startTime = DateTime.Now;
        for (int i = 0; i < n - 1; i++)
        {
            isSorted = true;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    isSorted = false;
                }
            }
            if (isSorted)
            {
                break;
            }
        }
        DateTime endTime = DateTime.Now;
        TimeSpan bubbleSortTime = endTime - startTime;

        // Вывод отсортированного массива на экран
        Console.WriteLine("Массив после сортировки пузырьком:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        // Сортировка методом подсчёта
        int[] countArr = new int[maxVal - minVal + 1];
        startTime = DateTime.Now;
        for (int i = 0; i < n; i++)
        {
            countArr[arr[i] - minVal]++;
        }
        int k = 0;
        for (int i = 0; i < countArr.Length; i++)
        {
            for (int j = 0; j < countArr[i]; j++)
            {
                arr[k++] = i + minVal;
            }
        }
        endTime = DateTime.Now;
        TimeSpan countingSortTime = endTime - startTime;

        // Вывод отсортированного массива на экран
        Console.WriteLine("Массив после сортировки методом подсчёта:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        // Вывод времени сортировок
        Console.WriteLine($"Время сортировки пузырьком: {bubbleSortTime.TotalMilliseconds} мс");
        Console.WriteLine($"Время сортировки методом подсчёта: {countingSortTime.TotalMilliseconds} мс");
