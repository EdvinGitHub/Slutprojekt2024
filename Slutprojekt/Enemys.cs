namespace Slutprojekt;
using Raylib_cs;
public class Enemys: Entity
{
//    PlayerSkript playerSkript = new PlayerSkript();
    float minspeed = 20;
    public override void Update(float deltaTime)
    {
        EnemyMovment();
        EnemysStuff();
        // base.Update(deltaTime);
    }
    public void Start()
    {

        speedX = minspeed;
    }
    public void EnemyMovment()
    {
        if (enemy.X > 700)
        {speedX = -minspeed;
        // Console.WriteLine("hej");
        }
        if (enemy.X < 0)
        {speedX = minspeed;   
        // Console.WriteLine("hejdå");
        }
        enemy.X += speedX;
    }
    public override void Draw()
    {
        Raylib.DrawRectangleRec(enemy, Color.Red);
    }
}
