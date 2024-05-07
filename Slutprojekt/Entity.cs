namespace Slutprojekt;

using System.Numerics;
using Raylib_cs;

// ärdra så att game objsekt är inte för entity 
public class Entity
{
  public List<Rectangle> enemytyp1 = new List<Rectangle>();


  public Rectangle enemy = new Rectangle(100, 100, 50, 50);

  protected List<Rectangle> floor = new List<Rectangle>();
  protected Rectangle floor1 = new Rectangle(0, 684, 900, 50);

  public Rectangle playerCharater = new Rectangle(200, 300, 100, 200);
  int listToAdd = 1;

  public int hp;
  public float speedX = 0;
  public float speedY = 0;


  protected float gravity = 2f;
  protected float velocity = 0;

  public virtual void Update(float deltaTime)
  {
  }
  public void EnemysStuff()
  {
    enemytyp1.Clear();
    enemytyp1.Add(enemy);
  }
  public void PlayerStuff()
  {
    if (listToAdd == 1)
    {
      floor.Add(floor1);
      listToAdd--;
    }
  }

  public virtual void Draw()
  {
  }
}

