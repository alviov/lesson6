using System;
using System.Collections.Generic;
using System.Text;
using lesson6;


namespace Lesson6
{
    abstract class Shape
    {
        public enum ShapeForm {Box, Ball, Cylinder, Pyramid}
        public virtual double Volume()
        {
            return default;
        }
        public virtual void ShowParameters()
        {

        }
    }
}
