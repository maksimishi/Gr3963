//Просим ввести число
Console.Write("Введи трёхзначное число: ");
// Вводим переменную преобразуем её в целое число
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
//Преобразуем число в строку чтобы получить только 2й элемент массива...
string stringNumber = Convert.ToString(threeDigitNumber);
// Выводим в консоль результат
Console.WriteLine("вторая цифра этого числа: " + stringNumber[1]);