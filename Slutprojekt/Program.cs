using System;
using System.Collections.Generic;
using Raylib_cs;
using System.Numerics;

float gravity = 0;
float ac = 0.04f;
float jump = -5;



//För kärmens storlek
Raylib.InitWindow(1000, 800, "Platformer");
Raylib.SetTargetFPS(60);

// X och Y. Den har två axlar. 
Vector2 position = new Vector2(10, 10);
Vector3 Collistion = new Vector3(position, 10);

Random Generator = new Random();
List<Rectangle> platforms = new List<Rectangle>();

platforms.Add(new Rectangle(100, 100, 100, 100));


float movementX = 0;
float movementY = 0;


bool undoX = false;
bool undoY = false;


void Collistions()
{


    position.X += movementX;

    foreach (Rectangle platform in platforms)
    {
        if (Raylib.CheckCollisionCircleRec(position, 40, platform))
        {
            undoX = true;
        }

    }

    position.Y += movementY;

    foreach (Rectangle platform in platforms)
    {
        if (Raylib.CheckCollisionCircleRec(position, 40, platform))
        {
            undoY = true;
        }

    }


    if (undoX == true)
    {
        position.X -= movementX;
    }
    if (undoY == true)
    {
        position.Y -= movementY;
    }

}

//För skärmens background
while (!Raylib.WindowShouldClose())
{
    movementX = 0;
    movementY = 0;
    undoX = false;
    undoY = false;

    //Så vilka knappar är movement och hur fort dom gör på sig.
    if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) movementX = -10;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) movementX = 10;
    // if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) movementY = 10;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
    {
        Console.WriteLine("Stupid");
       // Raylib.DrawRectangleRec(platforms[0], Color.BROWN);
       Raylib.DrawCircleV(position, 70, Color.BLACK);
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_L))
    {
        Raylib.DrawCircleV(position ,50, Color.RED);
    }

    if (position.Y + 40 >= Raylib.GetScreenHeight())
    {
        gravity = 0;
    }

    else
    {
        gravity += ac;
    }

    if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
    {
        gravity = jump;
    }

    movementY = gravity;


    //Så metoden anropas 
    Collistions();



    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.GREEN);
    Raylib.DrawCircleV(position, 40, Color.BLUE);

    foreach (Rectangle platform in platforms)
    {
        Raylib.DrawRectangleRec(platform, Color.BROWN);
    }







    //Så programmet inte stängs av på dirketen
    Raylib.EndDrawing();
}




