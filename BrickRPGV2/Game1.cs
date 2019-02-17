using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace BrickRPGV2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// 
    public class Game1 : Game
    {
        public static Vector2 CameraPawnOffset = new Vector2();
        public static Vector2 CameraPosition = new Vector2();
        public static Vector2 MapCameraPosition = new Vector2();

        public Bricky brick;
        public Entity map;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.ToggleFullScreen();
            //graphics.PreferredBackBufferWidth = 900;
            //graphics.PreferredBackBufferHeight = 600;
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            brick = new Bricky();
            map = new Entity();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            brick.loadContent(Content);
            brick.Position = new Vector2(graphics.PreferredBackBufferWidth/2,
                                            graphics.PreferredBackBufferHeight/2);
            brick.Position -= (brick.Sprite.getSize() / 2);
            
            map.Sprite = new AnimatedSprite2D(Content.Load<Texture2D>("map"),1,1);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            brick.Update();
            
            Vector2 velocity = new Vector2(0f,0f);

            //UP
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                velocity.Y -= 1;
            }
            //DOWN
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                velocity.Y += 1;
            }
            //LEFT
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                velocity.X -= 1;
            }
            //RIGHT
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                velocity.X += 1;
            }

            //RUN
            if (Keyboard.GetState().IsKeyDown(Keys.LeftShift))
            {
                velocity *= 2.5f;
            }

            if (velocity.X == 1 && velocity.Y == 0) { brick.Rotation = 0f; }
            else if (velocity.X == 1 && velocity.Y == 1) { brick.Rotation = 3.14159f / 4f; }
            else if (velocity.X == 0 && velocity.Y == 1) { brick.Rotation = 2f * 3.14159f / 4f; }
            else if (velocity.X == -1 && velocity.Y == 1) { brick.Rotation = 3f * 3.14159f / 4f; }
            else if (velocity.X == -1 && velocity.Y == 0) { brick.Rotation = 4f * 3.14159f / 4f; }
            else if (velocity.X == -1 && velocity.Y == -1) { brick.Rotation = 5f * 3.14159f / 4f; }
            else if (velocity.X == 0 && velocity.Y == -1) { brick.Rotation = 6f * 3.14159f / 4f; }
            else if (velocity.X == 1 && velocity.Y == -1) { brick.Rotation = 7f * 3.14159f / 4f; }

            //velocity.Normalize();

            //map.Move(-velocity*0.0f);
            //brick.Position.X += 1f * velocity.X;// velocity.X;
            //brick.Position.Y += 1f;// velocity.Y;
            //brick.Position = Vector2.Add(brick.Position, velocity);
            brick.Move(velocity.X,velocity.Y);
            
            //EXIT
            if (Keyboard.GetState().IsKeyDown(Keys.Escape)){Exit();}

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin(SpriteSortMode.Texture,
                              null, null, null, null, null,
                              Matrix.CreateTranslation(brick.Position.X, brick.Position.Y, 0));
            
            map.Draw(spriteBatch);
            brick.Draw(spriteBatch);
            
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
