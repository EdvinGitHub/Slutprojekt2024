namespace Slutprojekt;
using Raylib_cs;
public class UpdateSkripts : GameObjekt
{
    PlayerSkript playerSkript = new PlayerSkript();
    Enemys enemys = new Enemys();
    Entity entity = new Entity();
    // Maps maps = new Maps();
    int start= 1;
    public override void Update(float deltaTime)
    {
    if (start == 1)
    {
    enemys.Start();
    start--;
    }
    // entity.Update(deltaTime);
    playerSkript.Update(deltaTime);
    enemys.Update(deltaTime);
     Colision();
    // enemy.EnemyMovment();
    
    playerSkript.Draw();
    enemys.Draw();

    }
     public void Colision()
  {
    for (int i = 0; i <entity.enemytyp1.Count; i++)
    {
    if(Raylib.CheckCollisionRecs(playerSkript.playerCharater, entity.enemytyp1[i]))
    {
      Console.WriteLine("hej"); 
    }
    }
  }
}
