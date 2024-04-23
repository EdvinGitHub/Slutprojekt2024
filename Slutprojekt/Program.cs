using System.ComponentModel;
using Raylib_cs;
using Slutprojekt;

Player playerScript = new Player();
Entity entity = new Entity();
Enemys enemys = new Enemys();



Raylib.InitWindow(900,700,"Plat");
Raylib.SetTargetFPS(60);
while(!Raylib.WindowShouldClose())
{
    float deltaTime = Raylib.GetFrameTime();
    playerScript.Update(deltaTime);
    playerScript.Draw();
    enemys.Update(deltaTime);
    enemys.Draw();
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Gray);
    Raylib.EndDrawing();
}
