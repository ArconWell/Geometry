using Geometry;
using Geometry.Factories;

namespace UsageExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Код ниже написан просто для примера работы с библиотекой.
            //Обработку исключений (некорректный ввод пользователя итд) не стал делать :)
            Console.WriteLine("Enter the figure type (Circle/Triangle)");
            Console.Write(">");

            string? figureType = Console.ReadLine();

            double[] figureValues = new double[0];

            if (figureType == "circle")
            {
                Console.WriteLine("Enter circle radius");
                Console.Write(">");
                figureValues = new double[1];
                Double.TryParse(Console.ReadLine(), out figureValues[0]);
            }
            if (figureType == "triangle")
            {
                Console.WriteLine("Enter triangle sides");
                figureValues = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(">");
                    Double.TryParse(Console.ReadLine(), out figureValues[i]);
                }
            }

            FigureFactory factory = GetFactory(figureType, figureValues);
            Figure figure = factory.GetFigure();

            Console.WriteLine($"Площадь фигуры {figure.GetArea()}");
        }

        private static FigureFactory GetFactory(string figureType, params double[] figureValues)
        {
            switch (figureType.ToLower())
            {
                case "circle": return new CircleFactory(figureValues[0]);
                case "triangle": return new TriangleFactory(figureValues[0], figureValues[1], figureValues[2]);
                default: return null;
            }
        }
    }
}