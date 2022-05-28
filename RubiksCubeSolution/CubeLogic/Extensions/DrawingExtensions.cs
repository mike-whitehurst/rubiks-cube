using System.Drawing;

namespace CubeLogic.Extensions
{
    public static class DrawingExtensions
    {
        public static string ToShortString(this Color color)
        {
            return color.Name switch
            {
                "Green" => "G",
                "Red" => "R",
                "White" => "W",
                "Blue" => "B",
                "Orange" => "O",
                "Yellow" => "Y",
                _ => "f",
            };
        }
    }
}
