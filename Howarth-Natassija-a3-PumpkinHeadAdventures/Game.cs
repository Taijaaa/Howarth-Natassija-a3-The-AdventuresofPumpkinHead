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


        Platform[] platform = new Platform[13]
        int platform1Y = 420;
        Vector2 pumpkinHead;
        Vector2 Velocity;

        float playerSpeed = 175;
        float jumpStrength = 300; 
        float gravity = 600; 
        float groundLevel = 490; 


        // BACKGRROUND:
        Texture2D Background =
            Graphics.LoadTexture("../../../../assets/graphics/Background.png");


        // BRIDGES:

        Texture2D Bridge1 =
            Graphics.LoadTexture("../../../../assets/graphics/Bridge1.png");

       

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


            platforms =
        [
             new Platform(new Vector2(45, 360), Platform.platform5),
             new Platform(new Vector2(100, 445), Platform.platform4),
             new Platform(new Vector2(0, 420), Platform.platform1),
             new Platform(new Vector2(50, 500), Platform.platform2),
             new Platform(new Vector2(20, 570), Platform.platform3),
             new Platform(new Vector2(655, 330), Platform.platform5),
             new Platform(new Vector2(706, 460), Platform.platform6),
             new Platform(new Vector2(570, 385), Platform.platform6),
             new Platform(new Vector2(453, 445), Platform.platform4),
             new Platform(new Vector2(555, 505), Platform.platform4),
             new Platform(new Vector2(370, 570), Platform.platform3),
             new Platform(new Vector2(685, 570), Platform.platform3),
             new Platform(new Vector2(260, 471), Platform.platform13)
        ];



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
                Velocity.Y = 0; 
            }


            // bridge railing:

            Graphics.Draw(Bridge1, 260, 455);

            // bridge plank :

            Graphics.Draw(Bridge2, 260, 471);


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
