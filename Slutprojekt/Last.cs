namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;
public class Last : Player
{
    bool groundTrue = false;
    float gravity = -10f;
    List<Rectangle> walls = new List<Rectangle>();
    Rectangle wall1 = new Rectangle(0, 750 ,750, 50);
    Rectangle test = new Rectangle(0, 750, 0, 0);
    public override void Update(float deltaTime)
    {
        walls.Add(wall1);
        base.Update(deltaTime);
        PlayerMovment();
        for (int i = 0; i < walls.Count; i++)
        {
            if(Raylib.CheckCollisionRecs(ground, walls[i]))
            {groundTrue = true;
            test.Position = walls[i].Position; 
            ground.Y = test.Y-100;}
            // else
            // {groundTrue = false;}

        }
        if(groundTrue == false)
        {hej.Y -= gravity;}
        if (groundTrue == true)
        {
           
            hej.Y = ground.Y - 100;

        }
       
        
    }
}
