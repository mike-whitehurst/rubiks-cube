using CubeLogic.Classes;
using CubeLogic.Enums;

namespace Tests.Classes
{
    public class CubeTests
    {
        [Fact]
        public void AlwaysPass()
        {
            Assert.True(true);
        }

        [Fact]
        public void Constructor()
        {
            Cube cube = new();

            Assert.NotNull(cube);

            Assert.Equal("G,G,G;G,G,G;G,G,G", cube.FrontFace.ToString());
            Assert.Equal("R,R,R;R,R,R;R,R,R", cube.RightFace.ToString());
            Assert.Equal("W,W,W;W,W,W;W,W,W", cube.UpFace.ToString());
            Assert.Equal("B,B,B;B,B,B;B,B,B", cube.BackFace.ToString());
            Assert.Equal("O,O,O;O,O,O;O,O,O", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,Y;Y,Y,Y;Y,Y,Y", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateFrontFace_Clockwise()
        {
            Cube cube = new();

            cube.RotateFrontFace(DirectionTypes.Clockwise);

            Assert.Equal("G,G,G;G,G,G;G,G,G", cube.FrontFace.ToString());
            Assert.Equal("W,R,R;W,R,R;W,R,R", cube.RightFace.ToString());
            Assert.Equal("W,W,W;W,W,W;O,O,O", cube.UpFace.ToString());
            Assert.Equal("B,B,B;B,B,B;B,B,B", cube.BackFace.ToString());
            Assert.Equal("O,O,Y;O,O,Y;O,O,Y", cube.LeftFace.ToString());
            Assert.Equal("R,R,R;Y,Y,Y;Y,Y,Y", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateFrontFace_AntiClockwise()
        {
            Cube cube = new();

            cube.RotateFrontFace(DirectionTypes.AntiClockwise);

            Assert.Equal("G,G,G;G,G,G;G,G,G", cube.FrontFace.ToString());
            Assert.Equal("Y,R,R;Y,R,R;Y,R,R", cube.RightFace.ToString());
            Assert.Equal("W,W,W;W,W,W;R,R,R", cube.UpFace.ToString());
            Assert.Equal("B,B,B;B,B,B;B,B,B", cube.BackFace.ToString());
            Assert.Equal("O,O,W;O,O,W;O,O,W", cube.LeftFace.ToString());
            Assert.Equal("O,O,O;Y,Y,Y;Y,Y,Y", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateRightFace_Clockwise()
        {
            Cube cube = new();

            cube.RotateRightFace(DirectionTypes.Clockwise);

            Assert.Equal("G,G,Y;G,G,Y;G,G,Y", cube.FrontFace.ToString());
            Assert.Equal("R,R,R;R,R,R;R,R,R", cube.RightFace.ToString());
            Assert.Equal("W,W,G;W,W,G;W,W,G", cube.UpFace.ToString());
            Assert.Equal("W,B,B;W,B,B;W,B,B", cube.BackFace.ToString());
            Assert.Equal("O,O,O;O,O,O;O,O,O", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,B;Y,Y,B;Y,Y,B", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateRightFace_AntiClockwise()
        {
            Cube cube = new();

            cube.RotateRightFace(DirectionTypes.AntiClockwise);

            Assert.Equal("G,G,W;G,G,W;G,G,W", cube.FrontFace.ToString());
            Assert.Equal("R,R,R;R,R,R;R,R,R", cube.RightFace.ToString());
            Assert.Equal("W,W,B;W,W,B;W,W,B", cube.UpFace.ToString());
            Assert.Equal("Y,B,B;Y,B,B;Y,B,B", cube.BackFace.ToString());
            Assert.Equal("O,O,O;O,O,O;O,O,O", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,G;Y,Y,G;Y,Y,G", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateUpFace_Clockwise()
        {
            Cube cube = new();

            cube.RotateUpFace(DirectionTypes.Clockwise);

            Assert.Equal("R,R,R;G,G,G;G,G,G", cube.FrontFace.ToString());
            Assert.Equal("B,B,B;R,R,R;R,R,R", cube.RightFace.ToString());
            Assert.Equal("W,W,W;W,W,W;W,W,W", cube.UpFace.ToString());
            Assert.Equal("O,O,O;B,B,B;B,B,B", cube.BackFace.ToString());
            Assert.Equal("G,G,G;O,O,O;O,O,O", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,Y;Y,Y,Y;Y,Y,Y", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateUpFace_AntiClockwise()
        {
            Cube cube = new();

            cube.RotateUpFace(DirectionTypes.AntiClockwise);

            Assert.Equal("O,O,O;G,G,G;G,G,G", cube.FrontFace.ToString());
            Assert.Equal("G,G,G;R,R,R;R,R,R", cube.RightFace.ToString());
            Assert.Equal("W,W,W;W,W,W;W,W,W", cube.UpFace.ToString());
            Assert.Equal("R,R,R;B,B,B;B,B,B", cube.BackFace.ToString());
            Assert.Equal("B,B,B;O,O,O;O,O,O", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,Y;Y,Y,Y;Y,Y,Y", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateBackFace_Clockwise()
        {
            Cube cube = new();

            cube.RotateBackFace(DirectionTypes.Clockwise);

            Assert.Equal("G,G,G;G,G,G;G,G,G", cube.FrontFace.ToString());
            Assert.Equal("R,R,Y;R,R,Y;R,R,Y", cube.RightFace.ToString());
            Assert.Equal("R,R,R;W,W,W;W,W,W", cube.UpFace.ToString());
            Assert.Equal("B,B,B;B,B,B;B,B,B", cube.BackFace.ToString());
            Assert.Equal("W,O,O;W,O,O;W,O,O", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,Y;Y,Y,Y;O,O,O", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateBackFace_AntiClockwise()
        {
            Cube cube = new();

            cube.RotateBackFace(DirectionTypes.AntiClockwise);

            Assert.Equal("G,G,G;G,G,G;G,G,G", cube.FrontFace.ToString());
            Assert.Equal("R,R,W;R,R,W;R,R,W", cube.RightFace.ToString());
            Assert.Equal("O,O,O;W,W,W;W,W,W", cube.UpFace.ToString());
            Assert.Equal("B,B,B;B,B,B;B,B,B", cube.BackFace.ToString());
            Assert.Equal("Y,O,O;Y,O,O;Y,O,O", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,Y;Y,Y,Y;R,R,R", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateLeftFace_Clockwise()
        {
            Cube cube = new();

            cube.RotateLeftFace(DirectionTypes.Clockwise);

            Assert.Equal("W,G,G;W,G,G;W,G,G", cube.FrontFace.ToString());
            Assert.Equal("R,R,R;R,R,R;R,R,R", cube.RightFace.ToString());
            Assert.Equal("B,W,W;B,W,W;B,W,W", cube.UpFace.ToString());
            Assert.Equal("B,B,Y;B,B,Y;B,B,Y", cube.BackFace.ToString());
            Assert.Equal("O,O,O;O,O,O;O,O,O", cube.LeftFace.ToString());
            Assert.Equal("G,Y,Y;G,Y,Y;G,Y,Y", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateLeftFace_AntiClockwise()
        {
            Cube cube = new();

            cube.RotateLeftFace(DirectionTypes.AntiClockwise);

            Assert.Equal("Y,G,G;Y,G,G;Y,G,G", cube.FrontFace.ToString());
            Assert.Equal("R,R,R;R,R,R;R,R,R", cube.RightFace.ToString());
            Assert.Equal("G,W,W;G,W,W;G,W,W", cube.UpFace.ToString());
            Assert.Equal("B,B,W;B,B,W;B,B,W", cube.BackFace.ToString());
            Assert.Equal("O,O,O;O,O,O;O,O,O", cube.LeftFace.ToString());
            Assert.Equal("B,Y,Y;B,Y,Y;B,Y,Y", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateDownFace_Clockwise()
        {
            Cube cube = new();

            cube.RotateDownFace(DirectionTypes.Clockwise);

            Assert.Equal("G,G,G;G,G,G;O,O,O", cube.FrontFace.ToString());
            Assert.Equal("R,R,R;R,R,R;G,G,G", cube.RightFace.ToString());
            Assert.Equal("W,W,W;W,W,W;W,W,W", cube.UpFace.ToString());
            Assert.Equal("B,B,B;B,B,B;R,R,R", cube.BackFace.ToString());
            Assert.Equal("O,O,O;O,O,O;B,B,B", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,Y;Y,Y,Y;Y,Y,Y", cube.DownFace.ToString());
        }

        [Fact]
        public void RotateDownFace_AntiClockwise()
        {
            Cube cube = new();

            cube.RotateDownFace(DirectionTypes.AntiClockwise);

            Assert.Equal("G,G,G;G,G,G;R,R,R", cube.FrontFace.ToString());
            Assert.Equal("R,R,R;R,R,R;B,B,B", cube.RightFace.ToString());
            Assert.Equal("W,W,W;W,W,W;W,W,W", cube.UpFace.ToString());
            Assert.Equal("B,B,B;B,B,B;O,O,O", cube.BackFace.ToString());
            Assert.Equal("O,O,O;O,O,O;G,G,G", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,Y;Y,Y,Y;Y,Y,Y", cube.DownFace.ToString());
        }

        [Fact]
        public void SampleScenario()
        {
            Cube cube = new();

            cube.RotateFrontFace(DirectionTypes.Clockwise);
            cube.RotateRightFace(DirectionTypes.AntiClockwise);
            cube.RotateUpFace(DirectionTypes.Clockwise);
            cube.RotateBackFace(DirectionTypes.AntiClockwise);
            cube.RotateLeftFace(DirectionTypes.Clockwise);
            cube.RotateDownFace(DirectionTypes.AntiClockwise);

            Assert.Equal("O,R,R;O,G,W;W,W,W", cube.FrontFace.ToString());
            Assert.Equal("Y,B,O;R,R,W;O,Y,R", cube.RightFace.ToString());
            Assert.Equal("R,O,G;B,W,W;B,B,B", cube.UpFace.ToString());
            Assert.Equal("Y,B,W;O,B,Y;Y,Y,W", cube.BackFace.ToString());
            Assert.Equal("G,Y,Y;O,O,G;B,G,O", cube.LeftFace.ToString());
            Assert.Equal("G,G,B;R,Y,R;R,G,G", cube.DownFace.ToString());
        }

        [Fact]
        public void Reset()
        {
            Cube cube = new();

            cube.RotateFrontFace(DirectionTypes.Clockwise);
            cube.RotateRightFace(DirectionTypes.AntiClockwise);
            cube.RotateUpFace(DirectionTypes.Clockwise);
            cube.RotateBackFace(DirectionTypes.AntiClockwise);
            cube.RotateLeftFace(DirectionTypes.Clockwise);
            cube.RotateDownFace(DirectionTypes.AntiClockwise);

            cube.Reset();

            Assert.Equal("G,G,G;G,G,G;G,G,G", cube.FrontFace.ToString());
            Assert.Equal("R,R,R;R,R,R;R,R,R", cube.RightFace.ToString());
            Assert.Equal("W,W,W;W,W,W;W,W,W", cube.UpFace.ToString());
            Assert.Equal("B,B,B;B,B,B;B,B,B", cube.BackFace.ToString());
            Assert.Equal("O,O,O;O,O,O;O,O,O", cube.LeftFace.ToString());
            Assert.Equal("Y,Y,Y;Y,Y,Y;Y,Y,Y", cube.DownFace.ToString());
        }
    }
}
