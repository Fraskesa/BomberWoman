#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

#endregion
namespace BomberWomanMonoGame
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>

	//inherits from the Game class - provides the core functionality that all games should have 
	//abilities that were already defined in the Game class
	public class Game1 : Game
	{
		//link to the graphics device
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		//draw sprites (a fancy game development word for image) to the screen
		private Texture2D SpriteGround;
		private Texture2D SpriteStoneWall;
		private Texture2D SpriteBG;

		private Texture2D SpriteWalkDownStill;

		//private Texture2D SpriteMonsterSun;

		//Constructor
		//This sets up the graphics device manager and content manager
		public Game1 ()
		{ 
			//TODO: Correct the window size.
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";	   
			Window.AllowUserResizing = true; //makes it possible to resize the window.

		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize ()
		{
			//Sets the height to some specific sizes
			graphics.PreferredBackBufferWidth = (int)ScreenManager.Instance.Dimensions.X;
			graphics.PreferredBackBufferHeight = (int)ScreenManager.Instance.Dimensions.Y;
			graphics.ApplyChanges();


			// TODO: Add your initialization logic here
			base.Initialize ();

			 
				
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		/// Called periodically and frequently - run at 30 times per second (by default)
		/// This is where you update objects in your game world, handle user input, do collision detection, start audio playing, etc.
		protected override void LoadContent ()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch (GraphicsDevice);

			ScreenManager.Instance.LoadContent (Content);

			//TODO: use this.Content to load your game content here 
			SpriteGround = Content.Load<Texture2D> ("ground");
			SpriteStoneWall = Content.Load<Texture2D> ("stoneWall");
			SpriteBG = Content.Load<Texture2D> ("backGround");

			SpriteWalkDownStill = Content.Load<Texture2D> ("walkDownStill");

			//SpriteMonsterSun = Content.Load<Texture2D> ("monsterSun(1)");

		}

		protected override void UnloadContent ()
		{
			ScreenManager.Instance.UnloadContent();
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update (GameTime gameTime)
		{
			// For Mobile devices, this logic will close the Game when the Back button is pressed
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed) 
				Exit ();

			ScreenManager.Instance.Update (gameTime);

			// TODO: Add your update logic here			

			base.Update (gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		/// Drawn 30 times per second by default
		/// You should not be doing any updating in the Draw method, nor should you be doing any drawing in the Update method.
		protected override void Draw (GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear (Color.AliceBlue);

			//TODO: Add your drawing code here
			spriteBatch.Begin ();



			//Draw the Background
			spriteBatch.Draw (SpriteBG, new Rectangle (0, 0, 1000, 1000), Color.White);

			//Draw the spriteGround
			spriteBatch.Draw (SpriteGround, new Rectangle (50, 50, 800, 600), Color.White);

			//Draw the walls that cannot be removed
			//The Horisontal border of the game
			for (int i = 0; i < 750; i += 50) 
			{
				spriteBatch.Draw (SpriteStoneWall, new Rectangle (i,0, 50, 50), Color.White);
				spriteBatch.Draw (SpriteStoneWall, new Rectangle (i,500, 50, 50), Color.White);
			}

			//The vertical border of the game
			for (int j = 50; j < 500; j += 50) 
			{
				spriteBatch.Draw (SpriteStoneWall, new Rectangle (0, j, 50, 50), Color.White);
				spriteBatch.Draw (SpriteStoneWall, new Rectangle (700, j, 50, 50), Color.White);
			}

			//The middlestones of the game.
			for (int i = 100; i < 650; i += 100)
			{
				for (int j = 100; j < 450; j += 100) 
				{
					spriteBatch.Draw (SpriteStoneWall, new Rectangle (i, j, 50, 50), Color.White);
				}
			}  

			//This is the BomberWoman
			spriteBatch.Draw (SpriteWalkDownStill, new Rectangle(50, 50, 50, 50), Color.White);

			ScreenManager.Instance.Draw (spriteBatch);
			spriteBatch.End ();

			base.Draw (gameTime);
		}
	}
}

