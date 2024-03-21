namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;
 

  public class Entity : GameObjekt 
  {
    
    protected Rectangle playerCharater = new Rectangle(500, 300, 200,200);
    protected Rectangle groundCheck = new Rectangle(275, 250, 250,50);
    protected List<Rectangle> floor = new List<Rectangle>();
    protected Rectangle floor1 = new Rectangle(0, 750, 750, 50);
    protected Rectangle test = new Rectangle(0, 750, 0, 0);
    
    public int hp;
    public float speedX = 0;
    public float speedY = 0;

    protected bool groundTrue = false;
    protected float gravity = 2f;
    protected float velocity = 0;

    // private Vector2 velocity;
      
      



public override void Update(float deltaTime)
{
  // velocity = Vector2.Normalize(hej.Position);
  // velocity.Equals(hej);
  // player.PlayerMovment();
  playerCharater.X +=  speedX * deltaTime;
  playerCharater.Y +=  speedY * deltaTime;
  groundCheck.X = playerCharater.X - 25;
  groundCheck.Y = playerCharater.Y + 175;
}

public override void Draw()
{
  Raylib.DrawRectangleRec(playerCharater, Color.SkyBlue);
  Raylib.DrawRectangleRec(groundCheck, Color.Red);
}

  }

