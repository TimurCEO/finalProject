// Метод для фильтрации строк
    static string[] FilterStrings(string[] inputArray)
    {
        // Считаем количество строк, длина которых <= 3
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

