using System.ComponentModel;
using Raylib_cs;
using Slutprojekt;

Entity entity = new Entity();
Logic logic = new Logic();




Raylib.InitWindow(900,700,"Plat");
Raylib.SetTargetFPS(60);
while(true)
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Gray);
    entity.Draw();
    Raylib.EndDrawing();
}
