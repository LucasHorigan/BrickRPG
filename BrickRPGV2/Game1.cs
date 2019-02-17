using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BrickRPGV2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// 
    public class Game1 : Game
    {
        public static Vector2 CameraPawnOffset = new Vector2();

        public Bricky brick;
        public Entity map;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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
            map.Sprite = new AnimatedSprite2D(Content.Load<Texture2D>("map"),1,1);
            // TODO: use this.Content to load your game content here
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

            float velocity = 4.0f;

            //RUN
            if (Keyboard.GetState().IsKeyDown(Keys.LeftShift))
            {
                velocity = 16.0f;
            }

            //UP
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                brick.Move(new Vector2(0,-velocity));
            }
            //DOWN
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                brick.Move(new Vector2(0, velocity));
            }
            //LEFT
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                brick.Move(new Vector2(-velocity, 0));
            }
            //RIGHT
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                brick.Move(new Vector2(velocity, 0));
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            map.Draw(spriteBatch);
            brick.Draw(spriteBatch);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
