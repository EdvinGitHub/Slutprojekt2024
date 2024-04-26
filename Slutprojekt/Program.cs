using System.ComponentModel;
using Raylib_cs;
using Slutprojekt;
using System.Numerics;

// PlayerSkript playerScript = new PlayerSkript();
// Entity entity = new Entity();
// Enemys enemys = new Enemys();
UpdateSkripts updateSkripts = new UpdateSkripts();

int screenHeight = 700;
int screenWidth = 900;
int whatScean = 1; 
Raylib.InitWindow(screenWidth,screenHeight,"Plat");
// int thilemap = [];
// Texture2D texture;

// Texture2D tiles = Raylib.LoadTextureFromImage(@tiles.png);
Texture2D tiles = Raylib.LoadTexture(@"tiles.png");
    float frameWidth = tiles.Width/6;
    float frameHeight = tiles.Height/5;
  

    // Source rectangle (part of the texture to use for drawing)
    Rectangle sourceRec = new Rectangle(105, 0, frameWidth, frameHeight ); 

    // Destination rectangle (screen rectangle where drawing part of texture)
    Rectangle destRec = new Rectangle(  0, 650, 900, frameHeight*5 );

    // Origin of the texture (rotation/scale point), it's relative to destination rectangle size
    Vector2 origin = new Vector2(0, frameHeight) ;

    int rotation = 0;
    // Raylib.DrawTexture(tiles, 100, 200, Color.Black);


Raylib.SetTargetFPS(60);


while(!Raylib.WindowShouldClose())
{
    if (whatScean == 0)
    {
    float deltaTime = Raylib.GetFrameTime();
    // playerScript.Update(deltaTime);
    // enemys.Update(deltaTime);
    // enemys.EnemyMovment();
    // playerScript.Draw();
    // enemys.Draw();
    // Console.WriteLine(playerScript.playerCharater.X);
    updateSkripts.Update(deltaTime);
    updateSkripts.Colision();

    Raylib.DrawTexture(tiles, 40, 300, Color.White);
   
    Raylib.DrawTexturePro(tiles, sourceRec, destRec, origin, rotation, Color.White);
        

    }  
    else
    {
        Raylib.DrawText("You have to avoid the red cube or else will it typ HEJ",30, 300, 25, Color.Black);
        Raylib.DrawText("You move whith A to go left and D to go right and W to jump",30, 400, 25, Color.Black);
        Raylib.DrawText("press ENTER when you are ready",100, 500, 25, Color.Black);
        Raylib.DrawText("press ESC to leave",100, 600, 25, Color.Black);
        Raylib.BeginDrawing();
        if(Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            whatScean = 0;
        }

    }
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Gray);
    Raylib.EndDrawing();
}
