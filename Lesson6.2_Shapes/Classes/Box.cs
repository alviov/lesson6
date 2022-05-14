using System;
using System.Collections.Generic;
using System.Text;
using Lesson6;

namespace lesson6
{
    class Box : Shape
    {
        double H { get; }
        public Box(double H)
        { this.H = H; }
        public override double Volume()
        {
            double Vol = Math.Pow(H,3);
            return Vol;
        }
        public override void ShowParameters()
        {
            Console.WriteLine($"Box height is {H} box volume is {Volume(),2:F}");
        }
        public bool Add(Shape shape)
        {
            bool result = true;
            if ((Volume() - shape.Volume()) < 0) result = false;
            else result = true;
            return result;
        }
        public double Space(List<Shape> shapes)
        {
            double space = Volume();
            for (int i = 0; i < shapes.Count; i++)
            {
                space -= shapes[i].Volume();
            }
            return space;
        }
        public Box GenerateNewShape()
        {
            Box box = new Box(0);
            bool test = true;
            while (test)
            {
                Console.WriteLine("Please, insert box height H:");
                string height = Console.ReadLine();
                if (Double.TryParse(height, out double H))
                {
                    box = new Box(H);
                    test = false;
                }
                else
                {
                    Console.WriteLine("Oops, we've got troubles with input data. Please, try again");
                    test = true;
                }
            }
            return box;
        }
    }
}
