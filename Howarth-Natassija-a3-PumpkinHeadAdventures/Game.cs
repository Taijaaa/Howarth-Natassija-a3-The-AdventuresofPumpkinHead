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

        Texture2D Platform1 = 
            Graphics.LoadTexture("../../../../assets/graphics/Platform1.png");

        Texture2D Platform2 = 
            Graphics.LoadTexture("../../../../assets/graphics/Platform2.png");

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
            Graphics.LoadTexture("../../../../assets/graphics/Platform2.png");

        Texture2D Bridge1 =
            Graphics.LoadTexture("../../../../assets/graphics/Bridge1.png");

        Texture2D Bridge2 =
            Graphics.LoadTexture("../../../../assets/graphics/Bridge2.png");

        Texture2D PumpkinHead =
            Graphics.LoadTexture("../../../../assets/graphics/PumpkinHead.png");

        Texture2D Bats =
            Graphics.LoadTexture("../../../../assets/graphics/Bats.png");

        Texture2D Candy2 =
            Graphics.LoadTexture("../../../../assets/graphics/Candy2.png");



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

        Window.SetTitle("The Adventures of Pumpkin Head");
        Window.SetSize(800, 600);

            string cwd = Directory.GetCurrentDirectory();
            Console.WriteLine($"DIRECTORY: {cwd}");

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            // bridge railing

            Graphics.Draw(Bridge1, 260, 470);

            // bridge plank 

            Graphics.Draw(Bridge2, 260, 486);

            // left side platforms

            Graphics.Draw(Platform4, 100, 460);

            Graphics.Draw(Platform1, 0, 420);

            Graphics.Draw(Platform2, 60, 500);

            Graphics.Draw(Platform3, 55, 570);

            // right side platforms

            Graphics.Draw(Platform8, 570, 410);

            Graphics.Draw(Platform5, 453, 445);

            Graphics.Draw(Platform7, 520, 500);

            Graphics.Draw(Platform6, 400, 570);

            




            Graphics.Draw(PumpkinHead, 250, 265);
            Graphics.Draw(Bats, 100, 70);
            Graphics.Draw(Candy2, 100, 65);




        }

       



    }

}
