int[,] array = new int[4, 4];
FillArraySpirally(array);

// выводим массив
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0,2} ", array[i, j]);
    }
    Console.WriteLine();
}


static void FillArraySpirally(int[,] array)
{
    int x = 0, y = 0, dx = 0, dy = 1;

    // заполняем массив по спирали
    for (int i = 0; i < 16; i++)
    {
        array[x, y] = i + 1;
        if (x + dx < 0 || x + dx >= 4 || y + dy < 0 || y + dy >= 4 || array[x + dx, y + dy] != 0)
        {
            int temp = dx;
            dx = dy;
            dy = -temp;
        }
        x += dx;
        y += dy;
    }
}
