#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion
namespace BomberWomanMonoGame
{
	//inherits from the Game class - provides the core functionality that all games should have 
	public class Game1 : Game
	{
		//links to the graphics device
		GraphicsDeviceManager graphics;

		//draw sprites/images to the screen
		SpriteBatch spriteBatch;


		private Texture2D SpriteGround;
		private Texture2D SpriteStoneWall;
		private Texture2D SpriteBG;
		private Texture2D SpriteWalkDownStill;
		private Texture2D SpriteMonsterSun;

	


		//Constructor
		//It sets up the graphics device manager and content manager
		public Game1 ()
		{ 
			//Set the window size.
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";	   
			Window.AllowUserResizing = true; //makes it possible to resize the window.

		}

		//Allows the game to perform any initialization it needs to before starting to run.
		protected override void Initialize ()
		{
			//Sets the height to some specific sizes
			graphics.PreferredBackBufferWidth = (int)ScreenManager.Instance.Dimensions.X;
			graphics.PreferredBackBufferHeight = (int)ScreenManager.Instance.Dimensions.Y;
			graphics.ApplyChanges();

			//Add your initialization logic here
			base.Initialize ();
		}
			
		//LoadContent will be called once per game and is the place to load - run at 30 times per second (by default)
		//update objects,user input, do collision detection, start audio playing, etc.
		protected override void LoadContent ()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch (GraphicsDevice);

			ScreenManager.Instance.LoadContent (Content);

			SpriteGround = Content.Load<Texture2D> ("ground");
			SpriteStoneWall = Content.Load<Texture2D> ("stoneWall");
			SpriteBG = Content.Load<Texture2D> ("backGround");
			SpriteWalkDownStill = Content.Load<Texture2D> ("walkDownStill");
			SpriteMonsterSun = Content.Load<Texture2D> ("monsterSun(1)");
		}

		protected override void UnloadContent ()
		{
			ScreenManager.Instance.UnloadContent();
		}


		protected override void Update (GameTime gameTime)
		{
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed) {
			Exit ();
		}

	
			ScreenManager.Instance.Update (gameTime);

			base.Update (gameTime);
		
		}


		//This is called when the game should draw itself - drawn 30 times per second by default
		protected override void Draw (GameTime gameTime)
		{
			//Sets the background color
			graphics.GraphicsDevice.Clear (Color.AliceBlue);


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

			// A very usefull comment!
			ScreenManager.Instance.Draw (spriteBatch);

			spriteBatch.End ();

			base.Draw (gameTime);
		}
	}
}

