namespace Slutprojekt;
using Raylib_cs;
 

    public class Entity : GameObjekt
    {
        Rectangle hej = new Rectangle(500, 300, 200,200 );
        public int hp;

        public float speed;
   
        public override void Update(float deltaTime)
  {
    // rect.X += velocity.X * speed * deltaTime;

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

