namespace Slutprojekt;

public class UpdateSkripts : GameObjekt
{
    PlayerSkript playerSkript = new PlayerSkript();
    Enemys enemy = new Enemys();
    Entity entity = new Entity();
    // Maps maps = new Maps();
    int start= 1;
    public override void Update(float deltaTime)
    {
    if (start == 1)
    {
    enemy.Start();
    start--;
    }
    entity.Update(deltaTime);
    playerSkript.Update(deltaTime);
    enemy.Update(deltaTime);
    // enemy.EnemyMovment();
    playerSkript.Draw();
    enemy.Draw();
     
    }
}
