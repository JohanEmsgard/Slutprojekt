using System;
using System.Collections.Generic;
using Raylib_cs;

//För kärmens storlek
Raylib.InitWindow(1000, 800, "Platformer");
Raylib.SetTargetFPS(60);

//För skärmens background
while(!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.GREEN); 
    Raylib.DrawRectangle(100,100,100,100,Color.BLUE);

    //Så programmet inte stängs av på dirketen
    Raylib.EndDrawing();
}


Console.ReadLine();
