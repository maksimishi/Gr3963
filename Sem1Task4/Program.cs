using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Пожалуйста введите 3 числа: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
// Считаем максимальное число из 3х
        int max = Math.Max(num1, Math.Max(num2, num3));

        Console.WriteLine("Максимальное число из 3х это: {0}", max);
    }
}