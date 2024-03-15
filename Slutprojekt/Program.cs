using System.ComponentModel;
using Raylib_cs;
using Slutprojekt;

Last last = new Last();




Raylib.InitWindow(900,700,"Plat");
Raylib.SetTargetFPS(60);
while(true)
{
    float deltaTime = Raylib.GetFrameTime();
    last.Update(deltaTime);
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Gray);
    last.Draw();
    Raylib.EndDrawing();
}
