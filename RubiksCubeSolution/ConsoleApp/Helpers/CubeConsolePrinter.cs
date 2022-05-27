using CubeLogic.Classes;
using System.Drawing;

namespace ConsoleApp.Helpers
{
    public static class CubeConsolePrinter
    {
        ////*         +-------+
        ////*         | X X X |
        ////*         | X X X |
        ////*         | X X X |
        ////* +-------+-------+-------+-------+
        ////* | X X X | X X X | X X X | X X X |
        ////* | X X X | X X X | X X X | X X X |
        ////* | X X X | X X X | X X X | X X X |
        ////* +-------+-------+-------+-------+
        ////*         | X X X |
        ////*         | X X X |
        ////*         | X X X |
        ////*         +-------+

        public static void PrintCube(Cube cube)
        {
            PrintLine("*         +-------+"); 

            Print("*         | ");
            PrintSquare(cube.UpFace.Squares[0, 0]);
            PrintSquare(cube.UpFace.Squares[0, 1]);
            PrintSquare(cube.UpFace.Squares[0, 2]);
            PrintLine("|");
            Print("*         | ");
            PrintSquare(cube.UpFace.Squares[1, 0]);
            PrintSquare(cube.UpFace.Squares[1, 1]);
            PrintSquare(cube.UpFace.Squares[1, 2]);
            PrintLine("|");
            Print("*         | ");
            PrintSquare(cube.UpFace.Squares[2, 0]);
            PrintSquare(cube.UpFace.Squares[2, 1]);
            PrintSquare(cube.UpFace.Squares[2, 2]);
            PrintLine("|");

            PrintLine("* +-------+-------+-------+-------+");

            Print("* | ");
            PrintSquare(cube.LeftFace.Squares[0, 0]);
            PrintSquare(cube.LeftFace.Squares[0, 1]);
            PrintSquare(cube.LeftFace.Squares[0, 2]);
            Print("| ");
            PrintSquare(cube.FrontFace.Squares[0, 0]);
            PrintSquare(cube.FrontFace.Squares[0, 1]);
            PrintSquare(cube.FrontFace.Squares[0, 2]);
            Print("| ");
            PrintSquare(cube.RightFace.Squares[0, 0]);
            PrintSquare(cube.RightFace.Squares[0, 1]);
            PrintSquare(cube.RightFace.Squares[0, 2]);
            Print("| ");
            PrintSquare(cube.BackFace.Squares[0, 0]);
            PrintSquare(cube.BackFace.Squares[0, 1]);
            PrintSquare(cube.BackFace.Squares[0, 2]);
            PrintLine("|");

            Print("* | ");
            PrintSquare(cube.LeftFace.Squares[1, 0]);
            PrintSquare(cube.LeftFace.Squares[1, 1]);
            PrintSquare(cube.LeftFace.Squares[1, 2]);
            Print("| ");
            PrintSquare(cube.FrontFace.Squares[1, 0]);
            PrintSquare(cube.FrontFace.Squares[1, 1]);
            PrintSquare(cube.FrontFace.Squares[1, 2]);
            Print("| ");
            PrintSquare(cube.RightFace.Squares[1, 0]);
            PrintSquare(cube.RightFace.Squares[1, 1]);
            PrintSquare(cube.RightFace.Squares[1, 2]);
            Print("| ");
            PrintSquare(cube.BackFace.Squares[1, 0]);
            PrintSquare(cube.BackFace.Squares[1, 1]);
            PrintSquare(cube.BackFace.Squares[1, 2]);
            PrintLine("|");

            Print("* | ");
            PrintSquare(cube.LeftFace.Squares[2, 0]);
            PrintSquare(cube.LeftFace.Squares[2, 1]);
            PrintSquare(cube.LeftFace.Squares[2, 2]);
            Print("| ");
            PrintSquare(cube.FrontFace.Squares[2, 0]);
            PrintSquare(cube.FrontFace.Squares[2, 1]);
            PrintSquare(cube.FrontFace.Squares[2, 2]);
            Print("| ");
            PrintSquare(cube.RightFace.Squares[2, 0]);
            PrintSquare(cube.RightFace.Squares[2, 1]);
            PrintSquare(cube.RightFace.Squares[2, 2]);
            Print("| ");
            PrintSquare(cube.BackFace.Squares[2, 0]);
            PrintSquare(cube.BackFace.Squares[2, 1]);
            PrintSquare(cube.BackFace.Squares[2, 2]);
            PrintLine("|");

            PrintLine("* +-------+-------+-------+-------+");

            Print("*         | ");
            PrintSquare(cube.DownFace.Squares[0, 0]);
            PrintSquare(cube.DownFace.Squares[0, 1]);
            PrintSquare(cube.DownFace.Squares[0, 2]);
            PrintLine("|");
            Print("*         | ");
            PrintSquare(cube.DownFace.Squares[1, 0]);
            PrintSquare(cube.DownFace.Squares[1, 1]);
            PrintSquare(cube.DownFace.Squares[1, 2]);
            PrintLine("|");
            Print("*         | ");
            PrintSquare(cube.DownFace.Squares[2, 0]);
            PrintSquare(cube.DownFace.Squares[2, 1]);
            PrintSquare(cube.DownFace.Squares[2, 2]);
            PrintLine("|");

            PrintLine("*         +-------+");
        }

        private static void Print(string text, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
        }

        private static void PrintLine(string text, ConsoleColor color = ConsoleColor.Gray)
        {
            Print(text, color);
            Console.WriteLine();
        }

        private static void PrintSquare(Square square)
        {
            Print("X ", GetConsoleColor(square.Color));
        }

        private static ConsoleColor GetConsoleColor(Color color)
        {
            return color.Name switch
            {
                "Green" => ConsoleColor.Green,
                "Red" => ConsoleColor.Red,
                "White" => ConsoleColor.White,
                "Blue" => ConsoleColor.Blue,
                "Orange" => ConsoleColor.Cyan,
                "Yellow" => ConsoleColor.Yellow,
                _ => ConsoleColor.White,
            };
        }
    }
}
