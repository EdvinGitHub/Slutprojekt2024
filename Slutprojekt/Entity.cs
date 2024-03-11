namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;
 

    public class Entity : GameObjekt 
    {
        
        Rectangle hej = new Rectangle(500, 300, 200,200 );
        public int hp;
        public float speedX = 20f;
        public float speedY = 20f;
        private Vector2 velocity;
        
        

 

        public override void Update(float deltaTime)
  {
    // velocity = Vector2.Normalize(hej.Position);
    velocity.Equals(hej);
    hej.X += velocity.X * speedX * deltaTime;

    // if (rect.X + rect.Width > Raylib.GetScreenWidth())
    // {
    //   velocity = -velocity;
    // }
  }

  public override void Draw()
  {
    Raylib.DrawRectangleRec(hej, Color.SkyBlue);
  }

    }

