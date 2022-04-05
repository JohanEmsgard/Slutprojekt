using System;
using System.Collections.Generic;
using Raylib_cs;
using System.Numerics;

//För kärmens storlek
Raylib.InitWindow(1000, 800, "Platformer");
Raylib.SetTargetFPS(60);

// X och Y. Den har två axlar. 
Vector2 position = new Vector2(10, 10);

Random Generator = new Random();
List<Rectangle> platforms = new List<Rectangle>();

platforms.Add(new Rectangle(100, 100, 100, 100));

float movementX = 0;
float movementY = 0;

bool undoX = false;
bool undoY = false;

//För skärmens background
while (!Raylib.WindowShouldClose())
{
    movementX = 0;

    //Så vilka knappar är movement och hur fort dom gör på sig.
    if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) movementX = -10;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) movementX = 10;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) movementY = -10;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) movementY = 10;

    position.X += movementX;
    position.Y += movementY;


    if (undoY == true)
    {
        position.Y -= movementY;
    }

    movementY = 0;






    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.GREEN);
    Raylib.DrawCircleV(position, 40, Color.BLUE);

    Raylib.DrawRectangleRec(platforms[0], Color.BROWN);

    Raylib.DrawRectangle(10, 700, 500, 10, Color.BROWN);




    //Så programmet inte stängs av på dirketen
    Raylib.EndDrawing();
}


void Collistions()
{
    foreach (Rectangle platform in platforms)
    {
        if (Raylib.CheckCollisionCircleRec(position, 40, platform))
        {
            undoX = true;
        }

    }


    if (undoX == true)
    {
        position.X -= movementX;
    }



}



Console.ReadLine();
