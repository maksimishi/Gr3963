using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1%2==0)
        {
            Console.WriteLine("Число чётное! ");
        }
        else
        {
            Console.WriteLine("Число не чётное! ");
        }
    }
}
