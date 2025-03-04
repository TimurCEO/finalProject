using System;

class Program
{
    static void Main()
    {
        // Исходный массив строк
        string[] inputArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

        // Формируем новый массив из строк, длина которых <= 3
        string[] resultArray = FilterStrings(inputArray);

        // Выводим результат
        Console.WriteLine("Исходный массив:");
        PrintArray(inputArray);

        Console.WriteLine("\nНовый массив (строки длиной <= 3):");
        PrintArray(resultArray);
    }
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