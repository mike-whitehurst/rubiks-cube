using System.Drawing;

namespace CubeLogic.Classes
{
    public class Square
    {
        public Color Color { get; private set; }
        
        public Square(Color color)
        {
            Color = color;
        }
    }
}
