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
		private Texture2D SpriteMonsterSun;
		private Texture2D SpriteMonsterCup;
		private Texture2D SpriteMonsterEgg;
		private Texture2D SpriteHedge;
		private Texture2D SpriteBomb;
		private Texture2D SpriteWalkDownStill;
		private Texture2D SpriteBlast;
		private KeyboardState oldKeyBoardState;
		private Bomb myBomb;
		private BomberWoman myBomberWoman;
		private Enemy myEnemy;
		private BlastProofWall myBlastProofWall;
		private Walls myWall;
	


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
			graphics.PreferredBackBufferWidth = 850;
			graphics.PreferredBackBufferHeight = 650;
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


			SpriteGround = Content.Load<Texture2D> ("ground");
			SpriteStoneWall = Content.Load<Texture2D> ("stoneWall");
			SpriteBG = Content.Load<Texture2D> ("backGround");
			SpriteMonsterSun = Content.Load<Texture2D> ("monsterSun(1)");
			SpriteMonsterCup = Content.Load<Texture2D> ("monsterCup(1)");
			SpriteMonsterEgg = Content.Load<Texture2D> ("enemy3");
			SpriteHedge = Content.Load<Texture2D> ("hedge");
			SpriteBomb = Content.Load<Texture2D> ("bomb");
			SpriteWalkDownStill = Content.Load<Texture2D> ("walkDownStill");
			SpriteBlast = Content.Load<Texture2D> ("blast");
		}

		protected override void Update (GameTime gameTime)
		{
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed) {
			Exit ();
		}
							
			if (myBomberWoman != null) 
			{
				myBomberWoman.Update (gameTime);
			}

			if (myEnemy != null) 
			{
				myEnemy.Update (gameTime);
			}


			base.Update (gameTime);
		
		}


		//This is called when the game should draw itself - drawn 30 times per second by default
		protected override void Draw (GameTime gameTime)
		{
			//Allows for user keyboard inputs
			KeyboardState keyState = Keyboard.GetState ();

			//Sets the background color
			graphics.GraphicsDevice.Clear (Color.LightSeaGreen);


			spriteBatch.Begin ();

			//Draw the Background
			spriteBatch.Draw (SpriteBG, new Rectangle (0, 0, 1000, 1000), Color.White);

			//Draw the spriteGround
			spriteBatch.Draw (SpriteGround, new Rectangle (100, 100, 650, 450), Color.White);


			//Draws the stone walls (blastproof)

			if (true) 
			{
				if (keyState.IsKeyUp (Keys.Enter) && oldKeyBoardState.IsKeyDown (Keys.Enter)) 
				{
					myBlastProofWall = new BlastProofWall (SpriteStoneWall);
				}
			}

			if(myBlastProofWall != null)
				myBlastProofWall.Draw (spriteBatch);


			//Draws the hedge (non-blastproof)

			if (true) 
			{
				if (keyState.IsKeyUp (Keys.Enter) && oldKeyBoardState.IsKeyDown (Keys.Enter)) 
				{
					myWall = new Walls (SpriteHedge);
				}
			}

			if(myWall != null)
				myWall.Draw (spriteBatch);



			//Draws BomberWoman

			if (true) 
			{
				if (keyState.IsKeyUp (Keys.Enter) && oldKeyBoardState.IsKeyDown (Keys.Enter)) 
				{
					myBomberWoman = new BomberWoman (SpriteWalkDownStill);
				}
			}

			if (myBomberWoman != null)
				myBomberWoman.Draw (spriteBatch);


			//Draws an enemy

			if (true) 
			{
				if (keyState.IsKeyUp (Keys.Enter) && oldKeyBoardState.IsKeyDown (Keys.Enter)) 
				{
					myEnemy = new Enemy (SpriteMonsterSun, SpriteMonsterCup, SpriteMonsterEgg);
				}
			}

			if(myEnemy != null)
				myEnemy.Draw (spriteBatch);

			
			//Draws a bomb
			if (myBomb != null && myBomb.inGame == true) {
				myBomb.Update (gameTime);
			
				myBomb.Draw (spriteBatch);
			} else {
				if (keyState.IsKeyUp (Keys.Space) && oldKeyBoardState.IsKeyDown(Keys.Space)) 
				{

					myBomb = new Bomb(SpriteBomb, SpriteBlast, myBomberWoman.position.X, myBomberWoman.position.Y);
					//100,100,
				}

			}
			// Creating the blast images when the bomb disappears
			if (myBomb != null && myBomb.blast == true && myBomb.inGame != true) {
				myBomb.blastUpdate (gameTime);
				myBomb.blastDraw (spriteBatch);
			}

	
			oldKeyBoardState = keyState;

			spriteBatch.End ();

			base.Draw (gameTime);
		}
	}
}

