namespace Slutprojekt;
using Raylib_cs;
public class Player : Entity
{
    int maxhp = 3;

    float minspeed = 3;
    public Player()
    {
        hp = maxhp;
        speed = minspeed;
    }
    public void PlayerMovment()
    {
        if(Raylib.IsKeyDown(KeyboardKey.A))
        {}
        if(Raylib.IsKeyDown(KeyboardKey.D))
        {}
        if(Raylib.IsKeyDown(KeyboardKey.Space))
        {}
        // if(Raylib.IsKeyDown(KeyboardKey.S)) ?
        // {}
        
    }

}
