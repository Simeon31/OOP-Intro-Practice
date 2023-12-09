using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ColoredFigure figure = null;
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                string figureName = arr[0];
                string color = arr[1];
                double size = double.Parse(arr[2]);

                switch (figureName)
                {
                    case "Triangle":
                        figure = new Triangle(color, size);

                        figure.GetName();
                        figure.Show();
                        figure.GetArea();
                        break;
                    case "Circle":
                        figure = new Circle(color, size);

                        figure.GetName();
                        figure.Show();
                        figure.GetArea();
                        break;
                    case "Square":
                        figure = new Square(color, size);

                        figure.GetName();
                        figure.Show();
                        figure.GetArea();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
