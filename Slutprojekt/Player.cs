namespace Slutprojekt;
using Raylib_cs;
public class PlayerSkript : Entity
{
    protected Rectangle groundCheck = new Rectangle(275, 250, 100, 100);

    protected Rectangle test = new Rectangle(0, 750, 0, 0);

    int maxhp = 3;
    bool groundTrue = true;
    int amountOfAirJumps = 1;
    float minspeed = 300f;
    float jumpForce = 700f;
    public PlayerSkript()
    {
        hp = maxhp;
    }



    public override void Update(float deltaTime)
    {
        // base.Update(deltaTime);
        PlayerStuff();
        PlayerMovment();
        PlayerUpdates(deltaTime);
        PlayerGroundCheck();
        PlayerOutOfBounds();
        // playerCharater.Y *= velocity;
    }
    public override void Draw()
    {
        Raylib.DrawRectangleRec(playerCharater, Color.SkyBlue);
        // Raylib.DrawRectangleRec(groundCheck, Color.Red);
    }
    public void PlayerUpdates(float deltaTime)
    {

        velocity += gravity;
        speedY += velocity;
        playerCharater.Y += speedY * deltaTime;
        playerCharater.X += speedX * deltaTime;
        groundCheck.X = playerCharater.X;
        groundCheck.Y = playerCharater.Y + 175;


    }

    public void PlayerGroundCheck()
    {

        {
            groundTrue = false;
            for (int i = 0; i < floor.Count; i++)
            {
                if (Raylib.CheckCollisionRecs(groundCheck, floor[i]))
                {
                    groundTrue = true;
                    amountOfAirJumps = 1;
                    test.Position = floor[i].Position;
                    groundCheck.Y = test.Y - 50;
                    velocity = 0;
                }

            }


        }
        if (groundTrue == true)
        {
            if (playerCharater.Y >= groundCheck.Y - playerCharater.Height)
            {
                speedY = 0;
                playerCharater.Y = groundCheck.Y - playerCharater.Height;
            }
        }

    }
    public void PlayerMovment()
    {

        if (Raylib.IsKeyDown(KeyboardKey.A))
        { speedX = -minspeed; }
        if (Raylib.IsKeyDown(KeyboardKey.D))
        { speedX = minspeed; }
        if (Raylib.IsKeyUp(KeyboardKey.D) && Raylib.IsKeyUp(KeyboardKey.A))
        {
            if (speedX > 0) { speedX -= 10f; }
            if (speedX < 0) { speedX += 10f; }
        }

        if (amountOfAirJumps > 0)
        {
            if (Raylib.IsKeyPressed(KeyboardKey.Space) || Raylib.IsKeyPressed(KeyboardKey.W))
            {
                velocity = 0;
                speedY = 0;
                speedY -= jumpForce;
                amountOfAirJumps--;
            }
        }
        if (Raylib.IsKeyUp(KeyboardKey.Space) && Raylib.IsKeyUp(KeyboardKey.W))
        { if (speedY < 0) { speedY += 10f; } }
        if (Raylib.IsKeyDown(KeyboardKey.S))
        { speedY = 0; }

    }
    public void PlayerOutOfBounds()
    {
        if (playerCharater.X < 0)
        {
            playerCharater.X = 0;
            speedX = 0;
        }
        if (playerCharater.X > 800)
        {
            playerCharater.X = 800;
            speedX = 0;
        }
        if (playerCharater.Y < 0)
        {
            speedY = 0;
            playerCharater.Y = 0;
        }
        if (playerCharater.Y > 700)
        {
            playerCharater.Y = 700;
            speedY = 0;
        }

    }
}
