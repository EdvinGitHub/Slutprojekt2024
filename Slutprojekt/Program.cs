using System.ComponentModel;
using Raylib_cs;
using Slutprojekt;

Player playerScript = new Player();




Raylib.InitWindow(900,700,"Plat");
Raylib.SetTargetFPS(60);
while(!Raylib.WindowShouldClose())
{
    float deltaTime = Raylib.GetFrameTime();
    playerScript.Update(deltaTime);
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Gray);
    playerScript.Draw();
    Raylib.EndDrawing();
}
