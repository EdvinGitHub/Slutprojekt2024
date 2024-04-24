namespace Slutprojekt;
using Raylib_cs;
public class PlayerSkript : Entity
{
        protected Rectangle groundCheck = new Rectangle(275, 250, 100,100);

    protected Rectangle test = new Rectangle(0, 750, 0, 0);
    
    int maxhp = 3;

    float minspeed = 150f;
    float jumpForce = 1300f;
    public PlayerSkript()
    {
        hp = maxhp;
    }
    
        public Rectangle playerCharater = new Rectangle(200, 100, 100,200);

  public override void Update(float deltaTime)
    {
        

        base.Update(deltaTime);
        PlayerMovment();
        playerGroundCheck();
        
        velocity += gravity;
        speedY += velocity;
        playerCharater.X +=  speedX * deltaTime;
        playerCharater.Y +=  speedY * deltaTime;
        groundCheck.X = playerCharater.X - 25;
        groundCheck.Y = playerCharater.Y + 175;
        // playerCharater.Y *= velocity;
        if (groundCheck.Y > 700)
        {

        }
    }
    public override void Draw()
    {
        
     
        Raylib.DrawRectangleRec(playerCharater, Color.SkyBlue);
        Raylib.DrawRectangleRec(groundCheck, Color.Red);
    }
    public void playerGroundCheck()
    {
     
        {
    groundTrue = false;
    for (int i = 0; i < floor.Count; i++)
    {
        if (Raylib.CheckCollisionRecs(groundCheck, floor[i]))
        {
            groundTrue = true;

            test.Position = floor[i].Position;
            groundCheck.Y = test.Y - 50;
            velocity = 0;
        }

    }
      

  }
        if (groundTrue == true)
        {
            if (Raylib.IsKeyDown(KeyboardKey.Space) || Raylib.IsKeyDown(KeyboardKey.W) == false)
            {
                playerCharater.Y = groundCheck.Y - playerCharater.Height;
                speedY = 0;

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
        {velocity = 0 ;
        speedY = 0 ;
        speedY -= jumpForce;}
        if(Raylib.IsKeyUp(KeyboardKey.Space) && Raylib.IsKeyUp(KeyboardKey.W))
        {if(speedY <0){speedY += 10f;}}
        if(Raylib.IsKeyDown(KeyboardKey.S)) 
        {speedY = 0;}
        
    }

}
