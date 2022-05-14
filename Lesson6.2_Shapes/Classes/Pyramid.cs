using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    class Pyramid : Shape
    {
        double S { get; }
        double H { get; }
        public Pyramid(double S, double H)
        {
            this.S = S;
            this.H = H;
        }
        public override double Volume()
        {
            double Vol = S * H / 3;
            return Vol;
        }
        public override void ShowParameters()
        {
            Console.WriteLine($"Pyramid height is {H}, Pyramid square is {S}, Pyramid volume is {Volume(),2:F}");
        }

        public Pyramid GenerateNewShape()
        {
            Pyramid pyramid = new Pyramid(0, 0);
            bool test = true;
            while (test)
            {
                Console.WriteLine("Please, insert pyramid square S:");
                string square = Console.ReadLine();
                Console.WriteLine("Please, insert pyramid height H:");
                string height = Console.ReadLine();

                if (Double.TryParse(square, out double S) && Double.TryParse(height, out double H))
                {
                    pyramid = new Pyramid(S, H);
                    test = false;
                }
                else
                {
                    Console.WriteLine("Oops, we've got troubles with input data. Please, try again");
                    test = true;
                }
            }
            return pyramid;
        }

    }
}
