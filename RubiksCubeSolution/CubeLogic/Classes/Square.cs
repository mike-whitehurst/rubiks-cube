using CubeLogic.Enums;

namespace CubeLogic.Classes
{
    public class Square
    {
        public ColorTypes Color { get; private set; }
        
        public Square(ColorTypes color)
        {
            Color = color;
        }
    }
}
