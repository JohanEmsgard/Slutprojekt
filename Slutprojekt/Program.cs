using System;
using System.Collections.Generic;
using Raylib_cs;

Raylib.InitWindow(1000, 800, "Platformer");
Raylib.SetTargetFPS(60);


while(!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.GREEN);
    Raylib.EndDrawing();
}

Console.ReadLine();
