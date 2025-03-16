using System.Numerics;

namespace MohawkGame2D;

public class Candy
{
    public Vector2 position;
    public Vector2 size = new Vector2(26, 12);
    public Texture2D texture = Graphics.LoadTexture("../../../../assets/graphics/Candy2.png");

    public Vector2[] SpawnLocations =
  [
    new Vector2(55, 350),  // Near Platform 1 (Left side)
    new Vector2(120, 430), // Platform 2 (Middle left)
    new Vector2(275, 440), // Platform 13 (Bridge area)
    new Vector2(460, 420), // Platform 9 (Middle)
    new Vector2(580, 360), // Platform 8 (Right side lower)
    new Vector2(690, 310), // Platform 6 (Right side upper)
    new Vector2(705, 550)  // Platform 3 (Far right bottom)
  ];

    public Candy()
    {
        int candyChoice = Random.Integer(0, SpawnLocations.Length);
        position = SpawnLocations[candyChoice];
    }
}
