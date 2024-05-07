namespace Slutprojekt;
using Raylib_cs;
public class UpdateSkripts : GameObjekt
{
  PlayerSkript playerSkript = new PlayerSkript();
  Enemys enemys = new Enemys();

  int start = 1;
  public override void Update(float deltaTime)
  {
    if (start == 1)
    {
      enemys.Start();
      start--;
    }

    playerSkript.Update(deltaTime);
    enemys.Update(deltaTime);
    playerSkript.Draw();
    enemys.Draw();

  }
  public void Colision()
  {
    for (int i = 0; i < enemys.enemytyp1.Count; i++)
    {
      if (Raylib.CheckCollisionRecs(playerSkript.playerCharater, enemys.enemytyp1[i]))
      {
        Console.WriteLine("hej");
      }
    }
  }
}
