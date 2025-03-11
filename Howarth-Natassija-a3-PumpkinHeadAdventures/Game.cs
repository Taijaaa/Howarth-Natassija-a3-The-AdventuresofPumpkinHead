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

            Graphics.Draw(Platform1, 0, 0);
            Graphics.Draw(Platform2, 0, 0);
            Graphics.Draw(PumpkinHead, 250, 265);
            Graphics.Draw(Bats, 100, 70);
            Graphics.Draw(Candy2, 100, 65);




        }

       



    }

}
