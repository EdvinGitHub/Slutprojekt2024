namespace Slutprojekt;
using Raylib_cs;
public class Player : Entity
{
    
    int maxhp = 3;

    float minspeed = 50f;
    float jumpForce = 1300f;
    public Player()
    {
        hp = maxhp;
    }
    
        
  public override void Update(float deltaTime)
    {
      
      
        base.Update(deltaTime);
        PlayerMovment();
        playerGroundCheck();
        
        velocity += gravity;
        playerCharater.Y += velocity;



    }
    public void playerGroundCheck()
    {
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
           if (groundTrue == true)
        {
            if (Raylib.IsKeyDown(KeyboardKey.Space) || Raylib.IsKeyDown(KeyboardKey.W) == false)
            {

                playerCharater.Y = groundCheck.Y - 100;
            }

        }

    }
    public void PlayerMovment()
    {
        
        if(Raylib.IsKeyDown(KeyboardKey.A))
        {speedX = -minspeed;}
        if(Raylib.IsKeyDown(KeyboardKey.D))
        {speedX = minspeed;}
        if(Raylib.IsKeyUp(KeyboardKey.D) && Raylib.IsKeyUp(KeyboardKey.A))
        {if(speedX>0){speedX -= 5f;} 
        if(speedX<0){speedX += 5f;}}
       
        if(Raylib.IsKeyPressed(KeyboardKey.Space) || Raylib.IsKeyPressed(KeyboardKey.W))
        {speedY = 0;
        speedY -= jumpForce;}
        if(Raylib.IsKeyUp(KeyboardKey.Space) && Raylib.IsKeyUp(KeyboardKey.W))
        {if(speedY <0){speedY += 10f;}}
        if(Raylib.IsKeyDown(KeyboardKey.S)) 
        {speedY = 0;}
        
    }

}
