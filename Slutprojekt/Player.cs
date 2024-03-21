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
