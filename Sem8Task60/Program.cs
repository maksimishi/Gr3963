int[,,] array = CreateArray();

// выводим массив построчно с индексами
PrintArray(array);


static int[,,] CreateArray()
{
    int[,,] array = new int[2, 2, 2];
    int count = 10;

    // заполняем массив неповторяющимися двузначными числами
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = count++;
            }
        }
    }

    return array;
}

static void PrintArray(int[,,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("array[{0},{1},{2}] = {3}", i, j, k, array[i, j, k]);
            }
        }
    }
}

