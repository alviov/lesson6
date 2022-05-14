using System;
using System.Collections.Generic;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int pointAmount = rnd.Next(3, 5);
            Console.WriteLine($"Ok, there are {pointAmount} points");

            var pointCollection = PointUserInsert(pointAmount);

            GetPoints(pointCollection, pointAmount);

            Polygon polygon = new Polygon(pointCollection);

            polygon.ShowPerimeter();

            Console.ReadKey();
        }

        public static List<Point> PointUserInsert(int pointAmount)
        {
            var pointCollection = new List<Point>();

            for (int i = 1; i < pointAmount + 1; i++)
            {
                bool test = true;

                while (test)
                {
                    Console.WriteLine($"Enter point{i} coordinates: X1=");
                    string x_coordinate = Console.ReadLine();
                    Console.WriteLine($"Enter point{i} coordinates: Y2=");
                    string y_coordinate = Console.ReadLine();

                    if (Double.TryParse(x_coordinate, out double x_value) && Double.TryParse(y_coordinate, out double y_value))
                    {
                        Point point = new Point((i).ToString(), x_value, y_value);
                        pointCollection.Add(point);
                        test = false;
                    }
                    else
                    {
                        Console.WriteLine($"Unable to parse point{i} coordinates, try again");
                        test = true;
                    }
                }
            }
            return pointCollection;
        }

        public static void GetPoints(List<Point> pointCollection, int pointAmount)
        {
            for (int i = 0; i < pointAmount; i++)
            {
                pointCollection[i].ShowCoordinates();
            }
        }
    }
}
