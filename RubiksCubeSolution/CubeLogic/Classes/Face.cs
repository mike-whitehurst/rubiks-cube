using System.Drawing;

namespace CubeLogic.Classes
{
    public class Face
    {
        public Color Color { get; private set; }

        public Square[,] Squares { get; private set; }

        public Face(Color color)
        {
            Color = color;

            Squares = new Square[3, 3]
            {
                { new Square(color), new Square(color), new Square(color) },
                { new Square(color), new Square(color), new Square(color) },
                { new Square(color), new Square(color), new Square(color) },
            };
        }
    }
}
