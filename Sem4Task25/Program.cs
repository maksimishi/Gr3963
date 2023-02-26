
using System.Collections.Generic;

double num1 = ReadDouble("Введите первое число: ");
double num2 = ReadDouble("Введите второе число: ");

Console.WriteLine("Выберите операцию: ");
Console.WriteLine("+ - сложение");
Console.WriteLine("- - вычитание");
Console.WriteLine("* - умножение");
Console.WriteLine("/ - деление");
Console.WriteLine("^ - возведение в степень");

string op = Console.ReadLine();

Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>()
            {
                { "+", (a, b) => a + b },
                { "-", (a, b) => a - b },
                { "*", (a, b) => a * b },
                { "/", (a, b) => a / b },
                { "^", (a, b) => Math.Pow(a, b) }
            };

if (operations.TryGetValue(op, out Func<double, double, double> operation))
{
    double result = operation(num1, num2);
    Console.WriteLine("Результат: " + result);
}
else
{
    Console.WriteLine("Неправильный оператор");
}

static double ReadDouble(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine() ?? "0");
}

