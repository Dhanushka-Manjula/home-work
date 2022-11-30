using System;
using System.Reflection;
using System.Xml.Serialization;

namespace Module_2_Q_1
{
    [Serializable]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    public abstract class Shape
    {
        public string Colour;

        public abstract double Area();
    }
}

