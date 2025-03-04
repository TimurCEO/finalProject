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
// Создаем новый массив нужного размера
        string[] resultArray = new string[count];

        // Заполняем новый массив
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }    
 static void PrintArray(string[] array)
    {
        foreach (string str in array)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }
}