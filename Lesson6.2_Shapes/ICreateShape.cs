using System;
using System.Collections.Generic;
using System.Text;
using lesson6;


namespace Lesson6
{
    interface ICreateShape
    {
        Shape CreateShape(Shape.Shapeformat format);
    }
}
