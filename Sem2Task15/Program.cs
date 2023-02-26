Dictionary<int, string> daysOfWeek = new Dictionary<int, string>();

// Добавляем дни недели в словарь
daysOfWeek.Add(1, "Будний день");
daysOfWeek.Add(2, "Будний день");
daysOfWeek.Add(3, "Будний день");
daysOfWeek.Add(4, "Будний день");
daysOfWeek.Add(5, "Будний день");
daysOfWeek.Add(6, "Выходной");
daysOfWeek.Add(7, "Выходной");

// Просим ввести день недели
Console.Write("Введите день недели (1-7): ");
int dayOfWeek = int.Parse(Console.ReadLine() ?? "0");

// Проверяем выходной ли это или будний
if (daysOfWeek[dayOfWeek] == "Будний день")
{
    Console.WriteLine("Это будний день надо работать!");
}
else
{
    
    Console.WriteLine("Это Выходной! Можно расслабиться!");
}