using System;
using System.Linq;

namespace LAB07
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем массив из 10 фигур
            Shape[] shapes = new Shape[10]
            {
                new Circle(5),
                new Circle(2.5),
                new Rectangle(4, 6),
                new Rectangle(10, 2),
                new Triangle(3, 4, 5),
                new Triangle(6, 6, 6), // Равносторонний
                new Circle(10),
                new Rectangle(1, 1),
                new Triangle(5, 5, 6),
                new Rectangle(8, 8)
            };

            // Демонстрация ToString и работы операторов
            Console.WriteLine("--- Все фигуры в массиве ---");
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            // Сравнение двух фигур по площади
            Console.WriteLine("\n--- Проверка перегрузки операторов ---");
            Console.WriteLine($"Circle(5) > Rectangle(4, 6): {shapes[0] > shapes[2]}");
            Console.WriteLine($"Triangle(3, 4, 5) == Rectangle(1, 1): {shapes[4] == shapes[7]}");

            // 2. Дополнительная задача 1: фигура с максимальным отношением площади к периметру
            // Используем LINQ для поиска максимума
            Shape maxRatioShape = shapes.OrderByDescending(s => s.GetArea() / s.GetPerimeter()).First();
            double maxRatio = maxRatioShape.GetArea() / maxRatioShape.GetPerimeter();
            Console.WriteLine($"\n--- Задача 1: Максимальное отношение S/P ---");
            Console.WriteLine($"Это {maxRatioShape.ShapeName} с отношением {maxRatio:F4}");

            // 3. Дополнительная задача 2: фигура с минимальной площадью
            Shape minAreaShape = shapes.OrderBy(s => s.GetArea()).First();
            Console.WriteLine($"\n--- Задача 2: Минимальная площадь ---");
            Console.WriteLine($"Это {minAreaShape.ShapeName} с площадью {minAreaShape.GetArea():F4}");
        }
    }
}