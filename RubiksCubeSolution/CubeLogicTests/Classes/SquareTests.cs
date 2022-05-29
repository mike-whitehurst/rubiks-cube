using CubeLogic.Classes;
using CubeLogic.Enums;

namespace Tests.Classes
{
    public class SquareTests
    {
        [Fact]
        public void AlwaysPass()
        {
            Assert.True(true);
        }

        [Fact]
        public void Constructor()
        {
            Square square = new(ColorTypes.Green);

            Assert.NotNull(square);

            Assert.Equal(ColorTypes.Green, square.Color);
        }
    }
}