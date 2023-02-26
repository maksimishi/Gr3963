using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Первое число больше второго");
        }
        else if (num1 < num2)
        {
            Console.WriteLine("Второе число больше первого");
        }
        else
        {
            Console.WriteLine("Числа равны!");
        }
    }
}