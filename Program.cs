using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите координаты первого отрезка:");

        double start1 = ReadDouble("Введите начало первого отрезка: ");
        double end1 = ReadDouble("Введите конец первого отрезка: ");
        LineSegment segment1 = new LineSegment(start1, end1);

        // Унарная операция !
        LineSegment negatedSegment1 = !segment1;
        Console.WriteLine($"\nУнарная операция ! для первого отрезка: {negatedSegment1}");

        // Неявное приведение к int для первого отрезка
        int intValue1 = segment1; // Теперь это целая часть y (End)
        Console.WriteLine($"Неявное приведение к int для первого отрезка (целая часть y): {intValue1}");

        // Явное приведение к double для первого отрезка
        double doubleValue1 = (double)segment1; // Это x (Start)
        Console.WriteLine($"Явное приведение к double для первого отрезка (координата x): {doubleValue1:F2}");

        // Увеличиваем координату x для первого отрезка
        int valueToAddX = ReadInt("\nВведите число для увеличения координаты x первого отрезка: ");
        segment1.ShiftX(valueToAddX);
        Console.WriteLine($"После увеличения x первого отрезка: {segment1}");

        // Увеличиваем координату y для первого отрезка
        double valueToAddY = ReadDouble("\nВведите число для увеличения координаты y первого отрезка: ");
        segment1.ShiftY(valueToAddY);
        Console.WriteLine($"После увеличения y первого отрезка: {segment1}");

        Console.WriteLine("\nВведите координаты второго отрезка:");

        double start2 = ReadDouble("Введите начало второго отрезка: ");
        double end2 = ReadDouble("Введите конец второго отрезка: ");
        LineSegment segment2 = new LineSegment(start2, end2);

        // Унарная операция !
        LineSegment negatedSegment2 = !segment2;
        Console.WriteLine($"\nУнарная операция ! для второго отрезка: {negatedSegment2}");

        // Неявное приведение к int для второго отрезка
        int intValue2 = segment2; // Теперь это целая часть y (End)
        Console.WriteLine($"Неявное приведение к int для второго отрезка (целая часть y): {intValue2}");

        // Явное приведение к double для второго отрезка
        double doubleValue2 = (double)segment2; // Это x (Start)
        Console.WriteLine($"Явное приведение к double для второго отрезка (координата x): {doubleValue2:F2}");

        // Увеличиваем координату x для второго отрезка
        valueToAddX = ReadInt("\nВведите число для увеличения координаты x второго отрезка: ");
        segment2.ShiftX(valueToAddX);
        Console.WriteLine($"После увеличения x второго отрезка: {segment2}");

        // Увеличиваем координату y для второго отрезка
        valueToAddY = ReadDouble("\nВведите число для увеличения координаты y второго отрезка: ");
        segment2.ShiftY(valueToAddY);
        Console.WriteLine($"После увеличения y второго отрезка: {segment2}");

        // Проверка включает ли изменённый отрезок 1 отрезок 2
        bool isIncluded = segment1 > segment2;
        Console.WriteLine($"\nПервый отрезок включает второй: {isIncluded}");
    }

    private static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double result))
            {
                return result;
            }
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        }
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }
}
