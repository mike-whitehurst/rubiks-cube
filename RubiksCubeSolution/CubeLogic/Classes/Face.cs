using CubeLogic.Enums;

namespace CubeLogic.Classes
{
    public class Face
    {
        public ColorTypes Color { get; private set; }

        public Square[,] Squares { get; private set; }

        public Face(ColorTypes color)
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
                GetColorString(Squares[0, 0].Color),
                GetColorString(Squares[0, 1].Color),
                GetColorString(Squares[0, 2].Color),
                GetColorString(Squares[1, 0].Color),
                GetColorString(Squares[1, 1].Color),
                GetColorString(Squares[1, 2].Color),
                GetColorString(Squares[2, 0].Color),
                GetColorString(Squares[2, 1].Color),
                GetColorString(Squares[2, 2].Color)
            );
        }

        private static string GetColorString(ColorTypes color)
        {
            return color switch
            {
                ColorTypes.Green => "G",
                ColorTypes.Red => "R",
                ColorTypes.White => "W",
                ColorTypes.Blue => "B",
                ColorTypes.Orange => "O",
                ColorTypes.Yellow => "Y",
                _ => "_",
            };
        }
    }
}
