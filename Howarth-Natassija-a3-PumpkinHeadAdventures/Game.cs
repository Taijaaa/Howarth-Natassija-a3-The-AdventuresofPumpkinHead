// Include the namespaces (code libraries) you need below.
using System;
using System.ComponentModel.Design;
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

        bool playing = false;

        Platform[] platforms = new Platform[13];
        Bat[] bats = new Bat[5];
        const float batTimerDefault = 1.5f;
        float batTimer = batTimerDefault;
        float batMinSpeed = 2;
        float batMaxSpeed = 5;
        float batMinHeight = 100;
        float batMaxHeight = 400;
        float batSpawnX = 900;

        Candy[] candies = new Candy[3];
        int CandyCounter = 0;

        Vector2 pumpkinHead;
        Vector2 pumpkinHeadSize = new Vector2(55, 82);
        float pumpkinHeadWidthOffset = 10;
        Vector2 Velocity;

        float playerSpeed = 175;
        float jumpStrength = 310; // Jump force
        float gravity = 750; // Gravity speed

        // BACKGROUND
        Texture2D Background =
            Graphics.LoadTexture("../../../../assets/graphics/Background.png");

        // BRIDGES:

        Texture2D Bridge1 =
            Graphics.LoadTexture("../../../../assets/graphics/Bridge1.png");

        // PUMPKIN HEAD:

        Texture2D pumpkinHeadTexture =
            Graphics.LoadTexture("../../../../assets/graphics/PumpkinHead.png");

        public void Setup()
        {

            Window.SetTitle("The Adventures of Pumpkin Head");
            Window.SetSize(800, 600);

            pumpkinHead = new Vector2(190, 190);

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

        public void Update()
        {
            if (playing)
            {
                Playing();
            }
            else
            {
                Menu();
            }
        }

        public void Menu()
        {
            Window.ClearBackground(Color.OffWhite);
            Text.Draw("Press Space To Play", new Vector2(250, 250));

            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                playing = true;
                bats = new Bat[5];
            }
        }
        

        public void Playing()
        {
            Window.ClearBackground(Color.OffWhite);
            Graphics.Draw(Background, 0, 0);

            PlayerMovement();

            // bridge railing:

            Graphics.Draw(Bridge1, 260, 455);

            foreach (var platform in platforms)
            {
                platform.Render();
            }

            Graphics.Draw(pumpkinHeadTexture, pumpkinHead.X, pumpkinHead.Y);
            UpdateCandy();
            UpdateBats();
        }
        void PlayerMovement()
        {
            bool grounded = false;

            foreach (var platform in platforms)
            {
                // Is pumpkin head in line with the platform horizontally
                if ((pumpkinHead.X + pumpkinHeadWidthOffset > platform.position.X && pumpkinHead.X < platform.position.X + platform.width)
                    || (pumpkinHead.X + pumpkinHeadSize.X - pumpkinHeadWidthOffset > platform.position.X && pumpkinHead.X + pumpkinHeadSize.X < platform.position.X + platform.width))
                {
                    // Is pumpkin head on top of the platform
                    if (pumpkinHead.Y + pumpkinHeadSize.Y < platform.position.Y + platform.height / 2
                        && pumpkinHead.Y + pumpkinHeadSize.Y > platform.position.Y - platform.height / 2)
                    {
                        grounded = true;
                        Velocity = new Vector2(Velocity.X, 0);
                        pumpkinHead = new Vector2(pumpkinHead.X, platform.position.Y - pumpkinHeadSize.Y);
                    }
                }
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                pumpkinHead.X += Time.DeltaTime * playerSpeed;
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))

            {
                pumpkinHead.X -= Time.DeltaTime * playerSpeed;
            }

            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space) && grounded)
            {
                Velocity.Y = -jumpStrength; // Move up
            }

            if (!grounded)
            {
                Velocity.Y += gravity * Time.DeltaTime;
            }

            // Apply movement to the character
            pumpkinHead += Velocity * Time.DeltaTime;

        }


        void UpdateCandy()
        {
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] == null)
                {
                    candies[i] = new Candy();
                    break;
                }
                else
                {

                    Graphics.Draw(candies[i].texture, candies[i].position);
                }

                if (Vector2.Distance(candies[i].position, pumpkinHead + pumpkinHeadSize / 2) < 30f)
                {
                    candies[i] = null;

                    CandyCounter++;

                }

            }

            Text.Draw(CandyCounter.ToString(), new Vector2(400, 0));


        }
        void UpdateBats()
        {
            if (batTimer > 0)
            {
                batTimer -= Time.DeltaTime;
            }
            else
            {
                batTimer = batTimerDefault;
                for (int i = 0; i < bats.Length; i++)
                {
                    if (bats[i] == null)
                    {
                        bats[i] = new Bat(new Vector2(batSpawnX, Random.Float(batMinHeight, batMaxHeight)), new Vector2(-Random.Float(batMinSpeed, batMaxSpeed), 0));
                        break;
                    }
                    else
                    {
                        if (bats[i].position.X < 0 - bats[i].size.X)
                        {
                            bats[i] = null;
                        }
                    }
                }
            }

            foreach (Bat bat in bats)
            {
                if (bat is not null)
                {
                    bat.position += bat.velocity;
                    Graphics.Draw(bat.texture, bat.position);

                    if (Vector2.Distance(bat.position, pumpkinHead + pumpkinHeadSize / 2) < 40f)
                    {
                        playing = false;
                    }
                    if (pumpkinHead.Y > Window.Height)
                    {
                        playing = false;

                    }

                }
            }
        }
    }
}
