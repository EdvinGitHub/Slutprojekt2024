namespace Slutprojekt;
using Raylib_cs;
public class Enemys: Entity
{
   PlayerSkript playerSkript = new PlayerSkript();
    float minspeed = 1f;
    public override void Update(float deltaTime)
    {
        
        
    }

    public void EnemyMovment()
    {
        enemy.X += speedX;
        if (playerSkript.playerCharater.X > enemy.X)
        {speedX = minspeed;
        // Console.WriteLine("hej");
        }
        if (playerSkript.playerCharater.X < enemy.X)
        {speedX = -minspeed;   
        // Console.WriteLine("hejdå");
        }
    }
    public override void Draw()
    {
        Raylib.DrawRectangleRec(enemy, Color.Red);
    }
}
