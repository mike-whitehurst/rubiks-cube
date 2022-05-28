using CubeLogic.Enums;
using System.Drawing;

namespace CubeLogic.Classes
{
    public class Cube
    {
        public Face FrontFace { get; private set; }
        public Face RightFace { get; private set; }
        public Face UpFace { get; private set; }
        public Face BackFace { get; private set; }
        public Face LeftFace { get; private set; }
        public Face DownFace { get; private set; }

        public Cube()
        {
            Reset();
        }

        public void Reset()
        {
            FrontFace = new Face(Color.Green);
            RightFace = new Face(Color.Red);
            UpFace = new Face(Color.White);
            BackFace = new Face(Color.Blue);
            LeftFace = new Face(Color.Orange);
            DownFace = new Face(Color.Yellow);
        }

        public void RotateFrontFace(Direction direction)
        {
            RotateFace(FrontFace, direction);

            Shift(direction,
                ref RightFace.Squares[0, 0],
                ref DownFace.Squares[0, 2],
                ref LeftFace.Squares[2, 2],
                ref UpFace.Squares[2, 0]
            );

            Shift(direction,
                ref RightFace.Squares[1, 0],
                ref DownFace.Squares[0, 1],
                ref LeftFace.Squares[1, 2],
                ref UpFace.Squares[2, 1]
            );

            Shift(direction,
                ref RightFace.Squares[2, 0],
                ref DownFace.Squares[0, 0],
                ref LeftFace.Squares[0, 2],
                ref UpFace.Squares[2, 2]
            );
        }

        public void RotateRightFace(Direction direction)
        {
            RotateFace(RightFace, direction);

            Shift(direction,
                ref UpFace.Squares[2, 2],
                ref BackFace.Squares[0, 0],
                ref DownFace.Squares[2, 2],
                ref FrontFace.Squares[2, 2]
            );

            Shift(direction,
                ref UpFace.Squares[1, 2],
                ref BackFace.Squares[1, 0],
                ref DownFace.Squares[1, 2],
                ref FrontFace.Squares[1, 2]
            );

            Shift(direction,
                ref UpFace.Squares[0, 2],
                ref BackFace.Squares[2, 0],
                ref DownFace.Squares[0, 2],
                ref FrontFace.Squares[0, 2]
            );
        }

        public void RotateUpFace(Direction direction)
        {
            RotateFace(UpFace, direction);

            Shift(direction,
                ref BackFace.Squares[0, 0],
                ref RightFace.Squares[0, 0],
                ref FrontFace.Squares[0, 0],
                ref LeftFace.Squares[0, 0]
            );

            Shift(direction,
                ref BackFace.Squares[0, 1],
                ref RightFace.Squares[0, 1],
                ref FrontFace.Squares[0, 1],
                ref LeftFace.Squares[0, 1]
            );

            Shift(direction,
                ref BackFace.Squares[0, 2],
                ref RightFace.Squares[0, 2],
                ref FrontFace.Squares[0, 2],
                ref LeftFace.Squares[0, 2]
            );
        }

        public void RotateBackFace(Direction direction)
        {
            RotateFace(BackFace, direction);

            Shift(direction,
                ref RightFace.Squares[0, 2],
                ref UpFace.Squares[0, 0],
                ref LeftFace.Squares[2, 0],
                ref DownFace.Squares[2, 2]
            );

            Shift(direction,
                ref RightFace.Squares[1, 2],
                ref UpFace.Squares[0, 1],
                ref LeftFace.Squares[1, 0],
                ref DownFace.Squares[2, 1]
            );

            Shift(direction,
                ref RightFace.Squares[2, 2],
                ref UpFace.Squares[0, 2],
                ref LeftFace.Squares[0, 0],
                ref DownFace.Squares[2, 0]
            );
        }

        public void RotateLeftFace(Direction direction)
        {
            RotateFace(LeftFace, direction);

            Shift(direction,
                ref UpFace.Squares[0, 0],
                ref FrontFace.Squares[0, 0],
                ref DownFace.Squares[0, 0],
                ref BackFace.Squares[2, 2]
            );

            Shift(direction,
                ref UpFace.Squares[1, 0],
                ref FrontFace.Squares[1, 0],
                ref DownFace.Squares[1, 0],
                ref BackFace.Squares[1, 2]
            );

            Shift(direction,
                ref UpFace.Squares[2, 0],
                ref FrontFace.Squares[2, 0],
                ref DownFace.Squares[2, 0],
                ref BackFace.Squares[0, 2]
            );
        }

        public void RotateDownFace(Direction direction)
        {
            RotateFace(DownFace, direction);

            Shift(direction,
                ref FrontFace.Squares[2, 0],
                ref RightFace.Squares[2, 0],
                ref BackFace.Squares[2, 0],
                ref LeftFace.Squares[2, 0]
            );

            Shift(direction,
                ref FrontFace.Squares[2, 1],
                ref RightFace.Squares[2, 1],
                ref BackFace.Squares[2, 1],
                ref LeftFace.Squares[2, 1]
            );

            Shift(direction,
                ref FrontFace.Squares[2, 2],
                ref RightFace.Squares[2, 2],
                ref BackFace.Squares[2, 2],
                ref LeftFace.Squares[2, 2]
            );
        }

        private static void RotateFace(Face face, Direction direction)
        {
            Shift(direction,
                 ref face.Squares[0, 2],
                 ref face.Squares[2, 2],
                 ref face.Squares[2, 0],
                 ref face.Squares[0, 0]
            );

            Shift(direction,
                ref face.Squares[1, 2],
                ref face.Squares[2, 1],
                ref face.Squares[1, 0],
                ref face.Squares[0, 1]
           );
        }

        private static void Shift(Direction direction,
            ref Square a, ref Square b, ref Square c, ref Square d)
        {
            if (direction == Direction.Clockwise)
            {
                Square p = d;
                d = c;
                c = b;
                b = a;
                a = p;
            }
            else
            {
                Square p = a;
                a = b;
                b = c;
                c = d;
                d = p;
            }
        }
    }
}
