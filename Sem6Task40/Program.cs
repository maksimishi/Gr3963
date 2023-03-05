/*
Задача №40
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/

static bool IsTrianglePossible(double a, double b, double c)
{
    return a + b > c && b + c > a && a + c > b;
}

Console.Write("Введите длины сторон треугольника через пробел: ");
string input = Console.ReadLine() ?? "0";
string[] sides = input.Split();
double a = double.Parse(sides[0]);
double b = double.Parse(sides[1]);
double c = double.Parse(sides[2]);

if (IsTrianglePossible(a, b, c))
{
    Console.WriteLine("Треугольник с такими сторонами может существовать.");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами не может существовать.");
}