
// Запрашиваем у пользователя список имен, разделенных запятыми
Console.Write("Введите список имен, разделенных запятыми: ");
string input = Console.ReadLine();

// Разбиваем список имен на массив строк
string[] names = input.Split(',');

// Выбираем случайное имя из массива
Random random = new Random();
int index = random.Next(0, names.Length);
string name = names[index].Trim(); // Удаляем пробелы в начале и конце имени

// Выводим выбранное имя на экран
Console.WriteLine("Случайное имя: " + name);
