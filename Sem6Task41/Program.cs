﻿Console.Write("Введите число нажатий: "); //- выводим сообщение пользователю, чтобы он ввел число нажатий.
int keyPresses = int.Parse(Console.ReadLine()); // - считываем введенное пользователем число нажатий и сохраняем его в переменной

int count = 0; //- инициализируем переменную count, которая будет считать количество чисел больше 0

Console.WriteLine("Нажимайте клавиши и наблюдайте за изменением счетчика");

// - запускаем цикл, который будет работать до тех пор, пока пользователь не введет все запрошенные числа нажатий.
while (keyPresses > 0)
{
    //-считываем нажатую пользователем клавишу.
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    if (keyInfo.KeyChar > '0' && keyInfo.KeyChar <= '9') //- проверяем, является ли нажатая клавиша цифрой.
    {
        int number = keyInfo.KeyChar - '0';
        if (number > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Чисел больше 0: {count}"); // - уменьшаем количество оставшихся для ввода чисел на 1
    keyPresses--;
}