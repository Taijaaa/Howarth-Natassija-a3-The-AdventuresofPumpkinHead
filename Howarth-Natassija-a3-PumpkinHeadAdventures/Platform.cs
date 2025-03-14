using System.Numerics;


namespace MohawkGame2D;

public class Platform
{
    public Vector2 position;
    public float width;
    public float height = 10;
    public Texture2D texture;

    static Texture2D Platform1 =
        Graphics.LoadTexture("../../../../assets/graphics/Platform1.png");

    static Texture2D Platform2 =
        Graphics.LoadTexture("../../../../assets/graphics/Platform2.png");

    static Texture2D Platform3 =
        Graphics.LoadTexture("../../../../assets/graphics/Platform3.png");

    static Texture2D Platform4 =
        Graphics.LoadTexture("../../../../assets/graphics/Platform4.png");

    static Texture2D Platform5 =
        Graphics.LoadTexture("../../../../assets/graphics/Platform5.png");

    static Texture2D Platform6 =
        Graphics.LoadTexture("../../../../assets/graphics/Platform6.png");

    static Texture2D Platform13 =
         Graphics.LoadTexture("../../../../assets/graphics/platform7.png");

    public static Platform platform1 = new Platform(64, Platform1);
    public static Platform platform2 = new Platform(67, Platform2);
    public static Platform platform3 = new Platform(264, Platform3);
    public static Platform platform4 = new Platform(162, Platform4);
    public static Platform platform5 = new Platform(70, Platform5);
    public static Platform platform6 = new Platform(94, Platform6);
    public static Platform platform13 = new Platform(196, Platform13);

    Platform(float width, Texture2D texture)
    {
        position = Vector2.Zero;
        this.width = width;
        this.texture = texture;
    }

    public Platform(Vector2 position, Platform platform)
    {
        this.position = position;
        this.width = platform.width;
        this.texture = platform.texture;
    }

    public void Render()
    {
        Graphics.Draw(texture, position);
    }

