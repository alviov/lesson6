using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    class Ball : Shape
    {
        double R { get; }
        public Ball(double R)
        {
            this.R = R;
        }
        public override double Volume()
        {
            double Vol = Math.PI * Math.Pow(R, 3) * 4 / 3;
            return Vol;
        }
        public override void ShowParameters()
        {
            Console.WriteLine($"Ball radius is {R}, ball volume is {Volume(),2:F}");
        }

        public Ball GenerateNewShape()
        {
            Ball ball = new Ball(0);
            bool test = true;
            while (test)
            {
                Console.WriteLine("Please, insert ball radius R:");
                string radius = Console.ReadLine();
                if (Double.TryParse(radius, out double R))
                {
                    ball = new Ball(R);
                    test = false;
                }
                else
                {
                    Console.WriteLine("Oops, we've got troubles with input data. Please, try again");
                    test = true;
                }
            }
            return ball;
        }

    }
}
