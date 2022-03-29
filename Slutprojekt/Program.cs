using System;
using System.Collections.Generic;
using Raylib_cs;
using System.Numerics;

//För kärmens storlek
Raylib.InitWindow(1000, 800, "Platformer");
Raylib.SetTargetFPS(60);

// X och Y. Den har två axlar. 
Vector2 position = new Vector2(10, 10);

//För skärmens background
while(!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.GREEN); 
    Raylib.DrawRectangle((int)position.X,(int)position.Y,100,100,Color.BLUE);



    //Så vilka knappar är movement och hur fort dom gör på sig.
    if(Raylib.IsKeyDown(KeyboardKey.KEY_A)) position.X -= 10;
    if(Raylib.IsKeyDown(KeyboardKey.KEY_D)) position.X += 10;
    if(Raylib.IsKeyDown(KeyboardKey.KEY_W)) position.Y -= 10;
    if(Raylib.IsKeyDown(KeyboardKey.KEY_S)) position.Y += 10;


    //Så programmet inte stängs av på dirketen
    Raylib.EndDrawing();
}





Console.ReadLine();
