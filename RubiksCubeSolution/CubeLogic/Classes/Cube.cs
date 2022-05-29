using CubeLogic.Enums;

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
            FrontFace = new Face(ColorTypes.Green);
            RightFace = new Face(ColorTypes.Red);
            UpFace = new Face(ColorTypes.White);
            BackFace = new Face(ColorTypes.Blue);
            LeftFace = new Face(ColorTypes.Orange);
            DownFace = new Face(ColorTypes.Yellow);
        }

        public void RotateFrontFace(DirectionTypes direction)
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

        public void RotateRightFace(DirectionTypes direction)
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

        public void RotateUpFace(DirectionTypes direction)
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

        public void RotateBackFace(DirectionTypes direction)
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

        public void RotateLeftFace(DirectionTypes direction)
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

        public void RotateDownFace(DirectionTypes direction)
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

        private static void RotateFace(Face face, DirectionTypes direction)
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

        private static void Shift(DirectionTypes direction,
            ref Square a, ref Square b, ref Square c, ref Square d)
        {
            if (direction == DirectionTypes.Clockwise)
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
