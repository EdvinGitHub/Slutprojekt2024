namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;
 
// ärdra så att game objsekt är inte för entity 
  public class Entity  
  {
    protected List<Rectangle> enemytyp1 = new List<Rectangle>();


    protected Rectangle enemy = new Rectangle(100, 100, 50,50);

      protected List<Rectangle> floor = new List<Rectangle>();
    protected Rectangle floor1 = new Rectangle(0, 750, 750, 50);
     int listToAdd = 1;

    public int hp;
    public float speedX = 0;
    public float speedY = 0;

    protected bool groundTrue = true;
    protected float gravity = 2f;
    protected float velocity = 0;

    // private Vector2 velocity;
      




public virtual void Update(float deltaTime)
{
 enemytyp1.Add(enemy);
  // floor.Add(floor1);
  // velocity = Vector2.Normalize(hej.Position);
  // velocity.Equals(hej);
  // player.PlayerMovment();
   
    if (listToAdd == 1)
  {
    floor.Add(floor1);
    
    listToAdd--;
    Console.WriteLine("sasda");
  }
  
      
}

public virtual void Draw()
{
 

  // Raylib.DrawRectangleRec(playerCharater, Color.SkyBlue);
  // Raylib.DrawRectangleRec(groundCheck, Color.Red);
}

  }

