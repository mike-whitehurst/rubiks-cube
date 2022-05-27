# Rubik's Cube - A Technical Test

## Requirements

Develop a program that simulates a Rubik’s cube. The aim of the program is not to solve the cube, just to develop a programmatic Rubik’s cube that can correctly rotate any face.

You can use https://rubiks-cube-solver.com/ to help you develop your solution. The initial state of the cube in your solution should be "solved" and you should set your cube up the same way as they do, with the Green tiles at the front, Red tiles on the right-hand side and White tiles on the up face.

To test your solution, print out the colours on each face after applying the following face rotations to the starting position:
1. Front face clockwise 90°
2. Right face anti-clockwise 90°
3. Up face clockwise 90°
4. Back face anti-clockwise 90°
5. Left face clockwise 90°
6. Down face anti-clockwise 90°

You should print out the faces using the exploded view below.

![Image of desired outcome](/images/desired-outcome.png?raw=true)

You do not need to provide a UI, and a solution that prints out the solution using a console write statements is perfectly acceptable.

Although providing a working solution is good, there are other factors we will consider when we evaluate your program. For example, we will look to see if your code is close to "production quality" in terms of being readable, maintainable, testable, etc.

## Build & Run

To build and run:
1. Using Visual Studio 2022, open \RubiksCubeSolution\RubiksCubeSolution.sln
2. Press the play/start button to run ConsoleApp
3. Scroll up in the console window to read through the output

You should see the correct solution printed as below.

![Image of actual outcome](/images/actual-outcome2.png?raw=true)
