using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАЧА 1 ===");
        Console.WriteLine("Проверка: только одно число четное");
        Console.WriteLine("Введите три целых числа через пробел (например: 1 2 3):");
        string[] input1 = Console.ReadLine().Split(' ');
        int a1 = int.Parse(input1[0]);
        int b1 = int.Parse(input1[1]);
        int c1 = int.Parse(input1[2]);
        int evenCount = 0;
        if (a1 % 2 == 0) evenCount++;
        if (b1 % 2 == 0) evenCount++;
        if (c1 % 2 == 0) evenCount++;
        Console.WriteLine("Результат: " + (evenCount == 1 ? "истина" : "ложь"));

        Console.WriteLine("\n=== ЗАДАЧА 2 ===");
        Console.WriteLine("Найти максимальное число");
        Console.WriteLine("Введите три целых числа через пробел (например: 5 10 3):");
        string[] input2 = Console.ReadLine().Split(' ');
        int a2 = int.Parse(input2[0]);
        int b2 = int.Parse(input2[1]);
        int c2 = int.Parse(input2[2]);
        int max = Math.Max(Math.Max(a2, b2), c2);
        Console.WriteLine("Максимальное число: " + max);

        Console.WriteLine("\n=== ЗАДАЧА 3 ===");
        Console.WriteLine("Числа в порядке возрастания");
        Console.WriteLine("Введите три целых числа через пробел (например: 7 2 5):");
        string[] input3 = Console.ReadLine().Split(' ');
        int[] nums = new int[3];
        nums[0] = int.Parse(input3[0]);
        nums[1] = int.Parse(input3[1]);
        nums[2] = int.Parse(input3[2]);
        Array.Sort(nums);
        Console.WriteLine("Результат: " + nums[0] + " " + nums[1] + " " + nums[2]);

        Console.WriteLine("\n=== ЗАДАЧА 4 ===");
        Console.WriteLine("Проверка хода коня");
        Console.WriteLine("Введите координаты через пробел:");
        Console.WriteLine("x1 y1 x2 y2 (например: 1 1 2 3)");
        Console.WriteLine("где (x1,y1) - конь, (x2,y2) - фигура противника");
        string[] input4 = Console.ReadLine().Split(' ');
        int x1 = int.Parse(input4[0]);
        int y1 = int.Parse(input4[1]);
        int x2 = int.Parse(input4[2]);
        int y2 = int.Parse(input4[3]);
        int dx = Math.Abs(x1 - x2);
        int dy = Math.Abs(y1 - y2);
        bool knightHits = (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
        Console.WriteLine("Результат: " + (knightHits ? "бьет" : "не бьет"));

        Console.WriteLine("\n=== ЗАДАЧА 5 ===");
        Console.WriteLine("Проверка хода ферзя");
        Console.WriteLine("Введите координаты через пробел:");
        Console.WriteLine("x1 y1 x2 y2 (например: 1 1 3 3)");
        Console.WriteLine("где (x1,y1) - ферзь, (x2,y2) - фигура противника");
        string[] input5 = Console.ReadLine().Split(' ');
        int qx1 = int.Parse(input5[0]);
        int qy1 = int.Parse(input5[1]);
        int qx2 = int.Parse(input5[2]);
        int qy2 = int.Parse(input5[3]);
        bool queenHits = (qx1 == qx2) || (qy1 == qy2) || (Math.Abs(qx1 - qx2) == Math.Abs(qy1 - qy2));
        Console.WriteLine("Результат: " + (queenHits ? "бьет" : "не бьет"));

        Console.WriteLine("\n=== ЗАДАЧА 6 ===");
        Console.WriteLine("Проверка корректности даты");
        Console.WriteLine("Введите дату через пробел:");
        Console.WriteLine("день месяц год (например: 15 6 2023)");
        string[] input6 = Console.ReadLine().Split(' ');
        int day1 = int.Parse(input6[0]);
        int month1 = int.Parse(input6[1]);
        int year1 = int.Parse(input6[2]);
        bool isLeap1 = (year1 % 4 == 0 && year1 % 100 != 0) || (year1 % 400 == 0);
        int[] daysInMonth = { 31, isLeap1 ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        bool valid = year1 >= 1 && month1 >= 1 && month1 <= 12 && day1 >= 1 && day1 <= daysInMonth[month1 - 1];
        Console.WriteLine("Дата: " + (valid ? "корректна" : "некорректна"));

        Console.WriteLine("\n=== ЗАДАЧА 7 ===");
        Console.WriteLine("Дата следующего дня");
        Console.WriteLine("Введите корректную дату через пробел:");
        Console.WriteLine("день месяц год (например: 31 12 2023)");
        string[] input7 = Console.ReadLine().Split(' ');
        int day2 = int.Parse(input7[0]);
        int month2 = int.Parse(input7[1]);
        int year2 = int.Parse(input7[2]);
        bool isLeap2 = (year2 % 4 == 0 && year2 % 100 != 0) || (year2 % 400 == 0);
        int[] daysInMonth2 = { 31, isLeap2 ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        day2++;
        if (day2 > daysInMonth2[month2 - 1])
        {
            day2 = 1;
            month2++;
            if (month2 > 12)
            {
                month2 = 1;
                year2++;
            }
        }
        Console.WriteLine("Следующий день: " + day2 + " " + month2 + " " + year2);

        Console.WriteLine("\n=== ЗАДАЧА 8 ===");
        Console.WriteLine("Рубли с правильным падежом");
        Console.WriteLine("Введите целое число от 1 до 999:");
        int n = int.Parse(Console.ReadLine());
        int lastDigit = n % 10;
        int lastTwoDigits = n % 100;
        string word = "рубл";
        if (lastDigit == 1 && lastTwoDigits != 11) word += "ь";
        else if (lastDigit >= 2 && lastDigit <= 4 && !(lastTwoDigits >= 12 && lastTwoDigits <= 14)) word += "я";
        else word += "ей";
        Console.WriteLine("Результат: " + n + " " + word);

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}