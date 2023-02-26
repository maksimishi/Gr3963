Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());  // считываем число

int digitCount = (int)Math.Floor(Math.Log10(number) + 1);  // определяем количество цифр 

if (digitCount < 3)
{
    Console.WriteLine("Нет третьей цифры!");  // выводим сообщение, если количество цифр меньше трех
}
else
{
    int thirdDigit = (int)(number / Math.Pow(10, digitCount - 3)) % 10;  // вычисляем третью цифру путем деления числа на 10 в степени digitCount-3, а затем извлекаем остаток от деления на 10, чтобы получить третью цифру
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");  // выводим результат
}