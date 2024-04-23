namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;
 
// ärdra så att game objsekt är inte för entity 
  public class Entity : GameObjekt 
  {
    
    protected Rectangle playerCharater = new Rectangle(200, 100, 100,200);
    protected Rectangle groundCheck = new Rectangle(275, 250, 100,100);
    protected List<Rectangle> floor = new List<Rectangle>();
    protected List<Rectangle> enemytyp1 = new List<Rectangle>();
    protected Rectangle floor1 = new Rectangle(0, 750, 750, 50);
    protected Rectangle test = new Rectangle(0, 750, 0, 0);
    
    protected Rectangle enemy = new Rectangle(100, 100, 50,50);

    int listToAdd = 1;

    public int hp;
    public float speedX = 0;
    public float speedY = 0;

    protected bool groundTrue = true;
    protected float gravity = 2f;
    protected float velocity = 0;

    // private Vector2 velocity;
      

      



public override void Update(float deltaTime)
{
  if (listToAdd == 1)
  {
    floor.Add(floor1);
    enemytyp1.Add(enemy);
    listToAdd--;
    Console.WriteLine("sasda");
  }
  // floor.Add(floor1);
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
  // Raylib.DrawRectangleRec(playerCharater, Color.SkyBlue);
  // Raylib.DrawRectangleRec(groundCheck, Color.Red);
}

  }

