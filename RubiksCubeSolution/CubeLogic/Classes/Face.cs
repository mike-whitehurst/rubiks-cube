using CubeLogic.Extensions;
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

        public override string ToString()
        {
            return String.Format(
                "{0},{1},{2};{3},{4},{5};{6},{7},{8}",
                Squares[0, 0].Color.ToShortString(),
                Squares[0, 1].Color.ToShortString(),
                Squares[0, 2].Color.ToShortString(),
                Squares[1, 0].Color.ToShortString(),
                Squares[1, 1].Color.ToShortString(),
                Squares[1, 2].Color.ToShortString(),
                Squares[2, 0].Color.ToShortString(),
                Squares[2, 1].Color.ToShortString(),
                Squares[2, 2].Color.ToShortString()
            );
        }
    }
}
