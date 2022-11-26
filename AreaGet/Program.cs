using AreaLibraries;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            ResetConsole();

            // Ждем ввода пользователя
            string? choose = Console.ReadLine();

            // Если просто нажать Enter - программа закрывается
            if (string.IsNullOrEmpty(choose)) break;

            // Если выбрали (а) - расчитываем круг
            if (choose == "a")
            {
                CircleAreaRadiusFunc();
            }
            // Если выбрали (b) - расчитываем треугольник
            if (choose == "b")
            {
                TriangleAreaFunc();
            }


        } while (true);
        return;

        void ResetConsole()
        {
            // выводим подсказки для выбора
            Console.WriteLine($"{Environment.NewLine}Нажмите <Enter> для выхода; или выберете опцию и нажмите <Enter>:{Environment.NewLine}");
            Console.WriteLine($"{Environment.NewLine}   - 'a' : Расчитать площадь круга по радиусу");
            Console.WriteLine($"{Environment.NewLine}   - 'b' : Расчитать площадь треугольника по трем сторонам");
        }

        void CircleAreaRadiusFunc()
        {
            // Расчитываем площадь круга
            Console.WriteLine($"{Environment.NewLine}Укажите радиус круга:");
            string? radius = Console.ReadLine();
            double radiusInt = System.Convert.ToDouble(radius);

            Console.WriteLine("Площадь круга = " +
                    $"{(AreaLibrary.CircleAreaRadius(radiusInt))}");
            Console.WriteLine();

        }
        void TriangleAreaFunc()
        {
            // Расчитываем площадь треугольника
            Console.WriteLine($"{Environment.NewLine}Укажите первую сторону:");
            string? part1 = Console.ReadLine();
            double part1Int = System.Convert.ToDouble(part1);
            Console.WriteLine();

            Console.WriteLine($"{Environment.NewLine}Укажите вторую сторону:");
            string? part2 = Console.ReadLine();
            double part2Int = System.Convert.ToDouble(part2);
            Console.WriteLine();

            Console.WriteLine($"{Environment.NewLine}Укажите третью сторону:");
            string? part3 = Console.ReadLine();
            double part3Int = System.Convert.ToDouble(part3);
            Console.WriteLine();

            Console.WriteLine("Площадь треугольника = " +
                 $"{(AreaLibrary.TriangleArea(part1Int, part2Int, part3Int))}");
            Console.WriteLine();

            // Если треугольник - прямоугольный - выводим сообщение
            if (AreaLibrary.IsTriangle90(part1Int, part2Int, part3Int))
            {
                Console.WriteLine("Треугольник прямоугольный");
            Console.WriteLine();
            }

        }
    }
}