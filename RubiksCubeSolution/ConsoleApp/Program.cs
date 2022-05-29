using ConsoleApp.Helpers;
using CubeLogic.Classes;
using CubeLogic.Enums;

Console.WriteLine("Note that orange squares are cyan due to console output limitation.");
Console.WriteLine();

Console.WriteLine("Create cube with initial state:");
Cube cube = new();
CubeConsolePrinter.PrintCube(cube);

Console.WriteLine("Step 1. Rotate front face clockwise:");
cube.RotateFrontFace(DirectionTypes.Clockwise);
CubeConsolePrinter.PrintCube(cube);

Console.WriteLine("Step 2. Rotate right face anti-clockwise:");
cube.RotateRightFace(DirectionTypes.AntiClockwise);
CubeConsolePrinter.PrintCube(cube);

Console.WriteLine("Step 3. Rotate up face clockwise:");
cube.RotateUpFace(DirectionTypes.Clockwise);
CubeConsolePrinter.PrintCube(cube);

Console.WriteLine("Step 4. Rotate back face anti-clockwise:");
cube.RotateBackFace(DirectionTypes.AntiClockwise);
CubeConsolePrinter.PrintCube(cube);

Console.WriteLine("Step 5. Rotate left face clockwise:");
cube.RotateLeftFace(DirectionTypes.Clockwise);
CubeConsolePrinter.PrintCube(cube);

Console.WriteLine("Step 6. Rotate down face anti-clockwise:");
cube.RotateDownFace(DirectionTypes.AntiClockwise);
CubeConsolePrinter.PrintCube(cube);

Console.WriteLine("Completed sequence F R' U B' L D':");
CubeConsolePrinter.PrintCube(cube);

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
