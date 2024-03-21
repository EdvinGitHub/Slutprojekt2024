namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;
public class Last : Player
{

   
    public override void Update(float deltaTime)
    {
        floor.Add(floor1);
        base.Update(deltaTime);
        PlayerMovment();

        groundTrue = false;
        for (int i = 0; i < floor.Count; i++)
        {
            if (Raylib.CheckCollisionRecs(groundCheck, floor[i]))
            {
                groundTrue = true;

                test.Position = floor[i].Position;
                groundCheck.Y = test.Y - 100;
                velocity = 0;
            }

        }

        velocity += gravity;
        playerCharater.Y += velocity;

        if (groundTrue == true)
        {
            if (Raylib.IsKeyDown(KeyboardKey.Space) || Raylib.IsKeyDown(KeyboardKey.W) == false)
            {

                playerCharater.Y = groundCheck.Y - 100;
            }

        }


    }
}
