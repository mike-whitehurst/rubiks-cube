using CubeLogic.Classes;
using CubeLogic.Enums;

namespace Tests.Classes
{
    public class FaceTests
    {
        [Fact]
        public void AlwaysPass()
        {
            Assert.True(true);
        }

        [Fact]
        public void Constructor()
        {
            Face face = new(ColorTypes.Green);

            Assert.NotNull(face);

            Assert.Equal(ColorTypes.Green, face.Color);
        }

        [Theory]
        [InlineData(ColorTypes.Green, "G,G,G;G,G,G;G,G,G")]
        [InlineData(ColorTypes.Red, "R,R,R;R,R,R;R,R,R")]
        [InlineData(ColorTypes.White, "W,W,W;W,W,W;W,W,W")]
        [InlineData(ColorTypes.Blue, "B,B,B;B,B,B;B,B,B")]
        [InlineData(ColorTypes.Orange, "O,O,O;O,O,O;O,O,O")]
        [InlineData(ColorTypes.Yellow, "Y,Y,Y;Y,Y,Y;Y,Y,Y")]
        public void OverrideToString(ColorTypes color, string expected)
        {
            Face face = new(color);

            string output = face.ToString();

            Assert.Equal(expected, output);
        }
    }
}
