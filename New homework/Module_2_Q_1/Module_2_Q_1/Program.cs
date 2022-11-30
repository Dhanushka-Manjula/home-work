using System.Drawing;
using System.Xml.Serialization;

namespace Module_2_Q_1;
class Program
{
    static void Main(string[] args)
    {
        // create a list of Shapes to serialize
        var listOfShapes = new List<Shape>
        {
            new Circle { Colour = "Red", Radius = 2.5 },
            new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
            new Circle { Colour = "Green", Radius = 8 },
            new Circle { Colour = "Purple", Radius = 12.3 },
            new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
        };

        var serializer = new XmlSerializer(listOfShapes.GetType());
        using (var writer = new StreamWriter("listOfShapes.xml"))
        {
            serializer.Serialize(writer, listOfShapes);
        }

        List<Shape>? loadedShapesXml = serializer.Deserialize(new FileStream("listOfShapes.xml", FileMode.Open)) as List<Shape>;
        foreach (Shape item in loadedShapesXml)
        {
            Console.WriteLine($"{item.GetType().Name} is {item.Colour} and has an area of {item.Area()}");
        }
    }
}

