using System.Numerics;


namespace MohawkGame2D;

public class Bat
{
    public Vector2 position;
    public Vector2 velocity;
    public Vector2 size = new Vector2(93, 25);
    public Texture2D texture = Graphics.LoadTexture("../../../../assets/graphics/Bats.png");

    public Bat(Vector2 position, Vector2 velocity)
    {
        this.position = position;
        this.velocity = velocity;
    }
}
