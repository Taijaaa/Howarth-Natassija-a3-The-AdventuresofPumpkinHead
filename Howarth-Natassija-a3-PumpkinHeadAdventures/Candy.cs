using System.Numerics;

namespace MohawkGame2D;

public class Candy
{
    public Vector2 position;
    public Vector2 size = new Vector2(26, 12);
    public Texture2D texture = Graphics.LoadTexture("../../../../assets/graphics/Candy2.png");

    public Vector2[] SpawnLocations = [new Vector2(258, 450), new Vector2(49, 480), new Vector2(369, 550)];

    public Candy()
    {
        int candyChoice = Random.Integer(0, 3);
        position = SpawnLocations[candyChoice];
    }
}
