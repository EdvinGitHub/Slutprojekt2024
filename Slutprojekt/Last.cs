namespace Slutprojekt;

public class Last : Player
{
    float gravity = -10f;
    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);
        PlayerMovment();
        
        hej.Y -= gravity;
        if(hej.Y > 500)
        {hej.Y=500;}
    }
}
