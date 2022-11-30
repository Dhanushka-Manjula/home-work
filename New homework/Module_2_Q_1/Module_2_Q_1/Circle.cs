using System;
namespace Module_2_Q_1
{
    public class Circle : Shape
    {
        public double Radius;

        public Circle()
        {
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

