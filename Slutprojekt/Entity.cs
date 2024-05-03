namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;
 
// ärdra så att game objsekt är inte för entity 
  public class Entity  
  {
    public List<Rectangle> enemytyp1 = new List<Rectangle>();


    public Rectangle enemy = new Rectangle(100, 100, 50,50);

    protected List<Rectangle> floor = new List<Rectangle>();
    protected Rectangle floor1 = new Rectangle(0, 684, 900, 50);
      // protected List<Rectangle> gravityList = new List<Rectangle>();
    public Rectangle playerCharater = new Rectangle(200, 300, 100,200);
    int listToAdd = 1;

    public int hp;
    public float speedX = 0;
    public float speedY = 0;

   
    protected float gravity = 2f;
    protected float velocity = 0;

    // private Vector2 velocity;
      




public virtual void Update(float deltaTime)
{
 
  // floor.Add(floor1);
  // velocity = Vector2.Normalize(hej.Position);
  // velocity.Equals(hej);
  // player.PlayerMovment();
   
  // Colision();
      
}
public void EnemysStuff()
{
  // if (listToAdd == 1)
  // {
    enemytyp1.Clear();
    enemytyp1.Add(enemy);
    // floor.Add(floor1);
    // gravityList.Add(enemy);
    // gravityList.Add(playerCharater);
  //   listToAdd--;
  // }
}
  public void PlayerStuff()
  {
    if (listToAdd == 1)
  {
    // enemytyp1.Add(enemy);
    floor.Add(floor1);
    // gravityList.Add(enemy);
    // gravityList.Add(playerCharater);
    listToAdd--;
  }
  }
  // public void EnemyStuff()
  // {
  //   if (listToAdd == 1)
  // {
  //   enemytyp1.Add(enemy);
  //   floor.Add(floor1);
  //   // gravityList.Add(enemy);
  //   // gravityList.Add(playerCharater);
  //   listToAdd--;
  // }
  
  // }  

public virtual void Draw()
{
 

  // Raylib.DrawRectangleRec(playerCharater, Color.SkyBlue);
  // Raylib.DrawRectangleRec(groundCheck, Color.Red);
}

 
// public void Gravity()
// {
//  for (int i = 0; i < gravityList.Count; i++)
//  {
 
//  }
// }
  }

