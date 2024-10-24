using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LineSegment
{
    // Поля для координат начала и конца отрезка
    public double Start { get; private set; }
    public double End { get; private set; }

    // Конструктор
    public LineSegment(double start, double end)
    {
        // Если вторая координата больше первой
        if (start > end)
        {
            (start, end) = (end, start);
        }
        Start = start;
        End = end;
    }

    public LineSegment GetIntersection(LineSegment other)
    {
        // Проверяем, пересекаются ли отрезки
        if (End < other.Start || other.End < Start)
        {
            return null; // Нет пересечения
        }

        // Вычисляем начало и конец пересечения
        double intersectionStart = Math.Max(Start, other.Start);
        double intersectionEnd = Math.Min(End, other.End);

        return new LineSegment(intersectionStart, intersectionEnd);
    }

    // Унарная операция !
    public static LineSegment operator !(LineSegment segment)
    {
        return new LineSegment(0, segment.End - segment.Start);
    }

    // Операция приведения типа int (целая часть y)
    public static implicit operator int(LineSegment segment)
    {
        return (int)segment.End; // Возвращаем целую часть координаты y
    }

    // Операция приведения типа double (координата x)
    public static explicit operator double(LineSegment segment)
    {
        return segment.Start; // Возвращаем координату x
    }

    // Бинарная операция +
    public void ShiftX(int value)
    {
        Start += value;
    }

    // Бинарная операция для увеличения y
    public void ShiftY(double value)
    {
        End += value; // Предположим, что y соответствует End
    }

    // Операция >
    public static bool operator >(LineSegment left, LineSegment right)
    {
        return left.Start <= right.Start && left.End >= right.End;
    }

    public static bool operator <(LineSegment left, LineSegment right)
    {
        return !(left > right);
    }

    // Перегрузка метода ToString()
    public override string ToString()
    {
        return $"Отрезок: [{Start:F2}, {End:F2}]"; // Форматируем вывод до 2 знаков после запятой
    }
}
