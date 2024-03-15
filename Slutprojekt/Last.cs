namespace Slutprojekt;
using Raylib_cs;
public class Last : Player
{
    bool groundTrue = true;
    float gravity = -10f;
    List<Rectangle> walls = new List<Rectangle>();
    Rectangle wall1 = new Rectangle(0, 680 ,750, 20);
    public override void Update(float deltaTime)
    {
        walls.Add(wall1);
        base.Update(deltaTime);
        PlayerMovment();
        for (int i = 0; i < walls.Count; i++)
        {
            if(Raylib.CheckCollisionRecs(ground, walls[i]))
            {groundTrue = true;}
            else
            {groundTrue = false;}


        }
        if(groundTrue = false)
        { hej.Y -= gravity;}
       
        
    }
}
