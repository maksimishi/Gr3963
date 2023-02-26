
        // Создаем словарь для четырехзначных палиндромов
        Dictionary<int, bool> palindromes = new Dictionary<int, bool>();

        // Заполняем словарь четырехзначными палиндромами
        for (int i = 1001; i < 10000; i++)
        {
            string str = i.ToString();
            if (str[0] == str[3] && str[1] == str[2])
            {
                palindromes[i] = true;
            }
        }

        // Считываем пятизначное число 
        Console.Write("Введите пятизначное число: ");
        int inputNumber = int.Parse(Console.ReadLine() ?? "0");

        // Проверяем, является ли введенное число палиндромом
        bool isPalindrome = false;
        if (inputNumber >= 10000 && inputNumber <= 99999)
        {
            string inputString = inputNumber.ToString();
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);
            isPalindrome = inputString == reverseString;
        }

        // Проверяем, является ли введенное число четырехзначным палиндромом
        bool isFourDigitPalindrome = false;
        if (inputNumber >= 1000 && inputNumber <= 9999)
        {
            isFourDigitPalindrome = palindromes.ContainsKey(inputNumber);
        }

        // Выводим результат
        if (isPalindrome)
        {
            Console.WriteLine($"{inputNumber} является пятизначным палиндромом!");
        }
        else if (isFourDigitPalindrome)
        {
            Console.WriteLine($"{inputNumber} является четырехзначным палиндромом!");
        }
        else
        {
            Console.WriteLine($"{inputNumber} не является палиндромом!");
        }