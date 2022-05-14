using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6
{
    class Polygon
    {
        List<Point> _pointCollection { get; }
        public Polygon(List<Point> pointCollection)
        {
            _pointCollection = pointCollection;
        }
        public double Perimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < _pointCollection.Count - 1; i++) 
            {
                perimeter += Math.Sqrt(Math.Pow((_pointCollection[i + 1].GetXCoordinate() - _pointCollection[i].GetXCoordinate()),2) + Math.Pow((_pointCollection[i + 1].GetYCoordinate() - _pointCollection[i].GetYCoordinate()), 2));
            }
            return perimeter;
        }

        public void ShowPerimeter()
        {
            Console.WriteLine($"For the figure formed from identified points perimeter is: {Perimeter(),2:F}");
        }
    }   
}
