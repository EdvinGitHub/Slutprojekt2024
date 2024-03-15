namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;
 

    public class Entity : GameObjekt 
    {
      
      protected Rectangle hej = new Rectangle(500, 300, 200,200);
      protected Rectangle ground = new Rectangle(275, 250, 250,50);
      
      public int hp;
      public float speedX = 0;
      public float speedY = 0;
      // private Vector2 velocity;
        
        

 

  public override void Update(float deltaTime)
  {
    // velocity = Vector2.Normalize(hej.Position);
    // velocity.Equals(hej);
    // player.PlayerMovment();
    hej.X +=  speedX * deltaTime;
    hej.Y +=  speedY * deltaTime;
    ground.X = hej.X - 25;
    ground.Y = hej.Y + 175;
  }

  public override void Draw()
  {
    Raylib.DrawRectangleRec(hej, Color.SkyBlue);
    Raylib.DrawRectangleRec(ground, Color.Red);
  }

    }

