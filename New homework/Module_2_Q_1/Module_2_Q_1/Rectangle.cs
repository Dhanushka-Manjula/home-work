using System;
namespace Module_2_Q_1
{
    public class Rectangle : Shape
    {
        public double Height;
        public double Width;

        public Rectangle()
        {
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}

