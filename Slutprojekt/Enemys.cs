namespace Slutprojekt;
using Raylib_cs;
public class Enemys: Entity
{
    Player playerScript = new Player();
    float minspeed = 1f;
    public override void Update(float deltaTime)
    {
        enemy.X += speedX;
        if (playerCharater.X > enemy.X)
        {speedX = minspeed;
        Console.WriteLine("hej");}
        if (playerCharater.X < enemy.X)
        {speedX = -minspeed;   Console.WriteLine("hejdå");}
        
    }
    public override void Draw()
    {
        Raylib.DrawRectangleRec(enemy, Color.Red);
    }
}
