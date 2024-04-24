namespace Slutprojekt;

public class UpdateSkripts : GameObjekt
{
    PlayerSkript playerSkript = new PlayerSkript();
    Enemys enemys = new Enemys();
    Entity entity = new Entity();
    // Maps maps = new Maps();
    
    public override void Update(float deltaTime)
    {
    entity.Update(deltaTime);
    playerSkript.Update(deltaTime);
    enemys.EnemyMovment();
    playerSkript.Draw();
    enemys.Draw();
     
    }
}
