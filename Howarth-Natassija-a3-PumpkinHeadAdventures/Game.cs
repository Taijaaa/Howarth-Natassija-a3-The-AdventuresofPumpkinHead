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

        Texture2D texture = Graphics.LoadTexture("./Platforms.png");



        //Texture2D PlatformTexture = Graphics.LoadTexture("./Platforms.png");
        //Vector2 PlatformPosition = new Vector2(0, 400);


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

        Window.SetTitle("The Adventures of Pumpkin Head");
        Window.SetSize(800, 600);



        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            Graphics.Draw(texture, 0, 200);

        }

       



    }

}
