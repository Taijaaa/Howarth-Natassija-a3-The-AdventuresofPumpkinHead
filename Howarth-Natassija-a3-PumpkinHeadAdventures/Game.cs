// Include the namespaces (code libraries) you need below.
using System;
using System.IO;
using System.Numerics;


// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        int platform1Y = 420;
        Vector2 pumpkinHead;
        Vector2 Velocity;

        float playerSpeed = 175;
        float jumpStrength = 300; // Jump force
        float gravity = 600; // Gravity speed
        float groundLevel = 490; // Adjust to match platform height


        // BACKGRROUND
        Texture2D Background =
            Graphics.LoadTexture("../../../../assets/graphics/Background.png");

        // PLATFORMS:
        Texture2D Platform1 = 
            Graphics.LoadTexture("../../../../assets/graphics/Platform1.png");

        Texture2D Platform2 = 
            Graphics.LoadTexture("../../../../assets/graphics/Platform6.png");

        Texture2D Platform3 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform3.png");

        Texture2D Platform4 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform4.png");

        Texture2D Platform5 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform4.png");

        Texture2D Platform6 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform3.png");

        Texture2D Platform7 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform4.png");

        Texture2D Platform8 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform6.png");

        Texture2D Platform9 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform6.png");

        Texture2D Platform10 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform3.png");

        Texture2D Platform11 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform11.png");

        Texture2D Platform12 =
            Graphics.LoadTexture("../../../../assets/graphics/Platform11.png");


        // BRIDGES:

        Texture2D Bridge1 =
            Graphics.LoadTexture("../../../../assets/graphics/Bridge1.png");

        Texture2D Bridge2 =
            Graphics.LoadTexture("../../../../assets/graphics/Bridge2.png");

        // PUMPKIN HEAD:

        Texture2D PumpkinHead =
            Graphics.LoadTexture("../../../../assets/graphics/PumpkinHead.png");

        // BATS:

        Texture2D Bats =
            Graphics.LoadTexture("../../../../assets/graphics/Bats.png");

        Texture2D Bats2 =
            Graphics.LoadTexture("../../../../assets/graphics/Bats.png");

        Texture2D Bats3 =
            Graphics.LoadTexture("../../../../assets/graphics/Bats.png");

        // CANDY:

        Texture2D Candy2 =
            Graphics.LoadTexture("../../../../assets/graphics/Candy2.png");

        Texture2D Candy3 =
            Graphics.LoadTexture("../../../../assets/graphics/Candy2.png");



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

        Window.SetTitle("The Adventures of Pumpkin Head");
        Window.SetSize(800, 600);

        pumpkinHead = new Vector2(190, 490);

            string cwd = Directory.GetCurrentDirectory();
            Console.WriteLine($"DIRECTORY: {cwd}");

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            Graphics.Draw(Background, 0, 0);

            PlayerMovement();

            // Apply gravity
            Velocity.Y += gravity * Time.DeltaTime;

            // Apply movement to the character
            pumpkinHead += Velocity * Time.DeltaTime;

            // Prevent the character from falling below the ground
            if (pumpkinHead.Y > groundLevel)
            {
                pumpkinHead.Y = groundLevel;
                Velocity.Y = 0; // Stop falling
            }


            // bridge railing:

            Graphics.Draw(Bridge1, 260, 455);

            // bridge plank :

            Graphics.Draw(Bridge2, 260, 471);

            // left side platforms:

            Graphics.Draw(Platform12, 45, 360);

            Graphics.Draw(Platform4, 100, 445);

            Graphics.Draw(Platform1, 0, platform1Y);

            Graphics.Draw(Platform2, 50, 500);

            Graphics.Draw(Platform3, 20, 570);


            // right side platforms:

            Graphics.Draw(Platform11, 655, 330);

            Graphics.Draw(Platform9, 706, 460);

            Graphics.Draw(Platform8, 570, 385);

            Graphics.Draw(Platform5, 453, 445);

            Graphics.Draw(Platform7, 555, 505);

            Graphics.Draw(Platform6, 370, 570);

            Graphics.Draw(Platform10, 685, 570);


            Graphics.Draw(PumpkinHead, pumpkinHead.X, pumpkinHead.Y);

            Graphics.Draw(Bats, 200, 390);
            Graphics.Draw(Bats2, 487, 530);
            Graphics.Draw(Bats3, 600, 350);

            Graphics.Draw(Candy2, 595, 375);
            Graphics.Draw(Candy3, 71, 488);



        }
        void PlayerMovement()
        {

            if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                pumpkinHead.X += Time.DeltaTime * playerSpeed;
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))

            {
                pumpkinHead.X -= Time.DeltaTime * playerSpeed;
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.Space) && pumpkinHead.Y >= groundLevel)
            {

            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space) && pumpkinHead.Y == groundLevel)
            {
                Velocity.Y = -jumpStrength; // Move up
            }
        }



    }

}
