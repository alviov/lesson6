using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6
{
    class Cylinder : Shape
    {
        double H { get; }
        double R { get; }
        public override double Volume()
        {
            double Vol = Math.PI * R * R * H;
            Console.WriteLine($"The volume of the box is: {Vol}");
            return Vol;
        }

    }
}
