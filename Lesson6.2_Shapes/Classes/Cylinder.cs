using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    class Cylinder : Shape
    {
        double H { get; }
        double R { get; }
        public Cylinder(double H, double R)
        {
            this.H = H;
            this.R = R;
        }
        public override double Volume()
        {
            double Vol = Math.PI * Math.Pow(R,2) * H;
            return Vol;
        }
        public override void ShowParameters()
        {
            Console.WriteLine($"Cylinder radius is {R}, Cylinder height is {H}, Cylinder volume is {Volume(),2:F}");
        }

        public Cylinder GenerateNewShape()
        {
            Cylinder cylinder = new Cylinder(0, 0);
            bool test = true;
            while (test)
            {
                Console.WriteLine("Please, insert cylinder height H:");
                string height = Console.ReadLine();
                Console.WriteLine("Please, insert cylinder radius R:");
                string radius = Console.ReadLine();

                if (Double.TryParse(height, out double H) && Double.TryParse(radius, out double R))
                {
                    cylinder = new Cylinder(H, R);
                    test = false;
                }
                else
                {
                    Console.WriteLine("Oops, we've got troubles with input data. Please, try again");
                    test = true;
                }
            }
            return cylinder;
        }

    }
}
