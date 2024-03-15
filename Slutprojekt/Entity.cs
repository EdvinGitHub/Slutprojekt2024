namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;
 

    public class Entity : GameObjekt 
    {
      
      protected Rectangle hej = new Rectangle(500f, 300f, 200,200 );
      protected Rectangle Ground = new Rectangle(500f, 300f, 200,200 );
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

  }

  public override void Draw()
  {
    Raylib.DrawRectangleRec(hej, Color.SkyBlue);
  }

    }

