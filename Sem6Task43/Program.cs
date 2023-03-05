Console.WriteLine("Введите коэффициенты первой прямой y = k1 * x + b1");
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициенты второй прямой y = k2 * x + b2");
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициенты третьей прямой y = k3 * x + b3");
Console.Write("k3 = ");
double k3 = double.Parse(Console.ReadLine());
Console.Write("b3 = ");
double b3 = double.Parse(Console.ReadLine());

double x1 = (b2 - b1) / (k1 - k2);
double y1 = k1 * x1 + b1;
double x2 = (b3 - b2) / (k2 - k3);
double y2 = k2 * x2 + b2;
double x3 = (b1 - b3) / (k3 - k1);
double y3 = k3 * x3 + b3;

Console.WriteLine($"Точка пересечения трёх прямых: ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3})");

double area = Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0;
Console.WriteLine($"Площадь треугольника, образованного пересечением трёх прямых: {area}");