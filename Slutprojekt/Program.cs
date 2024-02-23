using System.ComponentModel;
using Raylib_cs;
using Slutprojekt;

Entity entity = new Entity();
GameObjekt gameObjekt = new GameObjekt();
Player player = new Player();
Enemys enemys = new Enemys();
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
