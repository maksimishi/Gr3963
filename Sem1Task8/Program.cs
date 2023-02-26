using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Пожалуйста введите число!: ");
        int numN = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <=numN; i=i+2)
        {
            Console.Write(i+ " ");
        }
    }
}