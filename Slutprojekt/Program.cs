using System.ComponentModel;
using Raylib_cs;
using Slutprojekt;
using System.Numerics;


UpdateSkripts updateSkripts = new UpdateSkripts(); // Där all kåd för spelt ligger 

int screenHeight = 700;
int screenWidth = 900;
int whatScean = 1;
Raylib.InitWindow(screenWidth, screenHeight, "Plat");


Texture2D tiles = Raylib.LoadTexture(@"tiles.png");
float frameWidth = tiles.Width / 6;
float frameHeight = tiles.Height / 5;
Rectangle sourceRec = new Rectangle(105, 0, frameWidth, frameHeight); //bestämer vilken del av bilden den ska använda   
Rectangle destRec = new Rectangle(0, 650, 900, frameHeight * 5); // vart den ska vara 
Vector2 origin = new Vector2(0, frameHeight); // just hur hög den ska vara texturen skrivas 

int rotation = 0;


Raylib.SetTargetFPS(60); // hur många freams per sekund 


while (!Raylib.WindowShouldClose())
{
    if (whatScean == 0) // vilken scean den är på 
    {
        float deltaTime = Raylib.GetFrameTime();

        updateSkripts.Update(deltaTime); // Updaterar kåden för spelet 
        updateSkripts.Colision(); // updaterar koliskoner för spelet 



        Raylib.DrawTexturePro(tiles, sourceRec, destRec, origin, rotation, Color.White);


    }
    else
    {
        Raylib.DrawText("You have to avoid the red cube or else will it typ HEJ", 30, 300, 25, Color.Black);
        Raylib.DrawText("You move whith A to go left and D to go right and W to jump", 30, 400, 25, Color.Black);
        Raylib.DrawText("press ENTER when you are ready", 100, 500, 25, Color.Black);
        Raylib.DrawText("press ESC to leave", 100, 600, 25, Color.Black);
        Raylib.BeginDrawing();
        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            whatScean = 0;
        }

    }
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Gray);
    Raylib.EndDrawing();
}
