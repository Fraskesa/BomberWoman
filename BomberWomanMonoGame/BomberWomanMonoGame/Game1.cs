#region Using Statements
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
#endregion

namespace BomberWomanMonoGame
{
	//Inherits from the Game class - provides the core functionality of the game and is where we load textures and decide when different things should happen 
	public class Game1 : Game
	{
		//Links to the graphics device
		GraphicsDeviceManager graphics;

		//Draw sprites/images to the screen
		SpriteBatch spriteBatch;

		//Attributes
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

		//Instanciation of classes
		private Bomb myBomb;
		private BomberWoman myBomberWoman;
		private Enemy myEnemy;
		private BlastProofWall myBlastProofWall;
		private Walls myWall;

		//Used for storing last key pressed in order to not activate loading of of content more then one time when pressing Enter
		private KeyboardState oldKeyBoardState;
	

		//Constructor
		//It sets up the graphics device manager and content manager
		public Game1 ()
		{ 
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";
			//makes it possible to resize the window.
			Window.AllowUserResizing = true; 
		}

		//Add your initialization logic here
		protected override void Initialize ()
		{
			//Set the window size.
			graphics.PreferredBackBufferWidth = 850;
			graphics.PreferredBackBufferHeight = 650;
			graphics.ApplyChanges();

			base.Initialize ();
		}
			
		//LoadContent will be called once per game and is the place to load
		protected override void LoadContent ()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch (GraphicsDevice);

			//Loading of images
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

		//This is where we constantly check for things that need updating  - runs at 30 times per second (by default)
		protected override void Update (GameTime gameTime)
		{
			//If we have made an istance of the classes call their update method.
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


		//This is where we place what should be drawn to the screen - drawn 30 times per second by default.
		protected override void Draw (GameTime gameTime)
		{
			//Allows for user keyboard inputs
			KeyboardState keyState = Keyboard.GetState ();

			//Sets the background color
			graphics.GraphicsDevice.Clear (Color.LightSeaGreen);

			//Needed to draw (draw between a begin and an end)
			spriteBatch.Begin ();

			//Draw the Background
			spriteBatch.Draw (SpriteBG, new Rectangle (0, 0, 1000, 1000), Color.White);

			//Draws the spriteGround (the grass)
			spriteBatch.Draw (SpriteGround, new Rectangle (100, 100, 650, 450), Color.White);


			//Much of the following code can be shortened so that they are all put under the same Enter press, 
			//but with this structure it allows for easier change and order for us.
			//Draws the stone walls (blastproof)
			if (true) 
			{
				if (keyState.IsKeyUp (Keys.Enter) && oldKeyBoardState.IsKeyDown (Keys.Enter)) 
				{
					myBlastProofWall = new BlastProofWall (SpriteStoneWall);
				}
			}

			if (myBlastProofWall != null)
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
				
			//Draws the enemies
			if (true) 
			{
				if (keyState.IsKeyUp (Keys.Enter) && oldKeyBoardState.IsKeyDown (Keys.Enter)) 
				{
					myEnemy = new Enemy (SpriteMonsterSun, SpriteMonsterCup, SpriteMonsterEgg);
				}
			}

			if(myEnemy != null)
				myEnemy.Draw (spriteBatch);
				
			//Draws a bomb when space is pressed
			if (myBomb != null && myBomb.bombOnScreen == true) {
				myBomb.Update (gameTime);
				myBomb.Draw (spriteBatch);

			} else {
				if (keyState.IsKeyUp (Keys.Space) && oldKeyBoardState.IsKeyDown(Keys.Space)) 
				{
					myBomb = new Bomb(SpriteBomb, SpriteBlast, myBomberWoman.position.X, myBomberWoman.position.Y);
				}
			}

			//Creating the blast images when the bomb disappears
			if (myBomb != null && myBomb.blastOnScreen == true && myBomb.bombOnScreen != true) {
				myBomb.blastUpdate (gameTime);
				myBomb.blastDraw (spriteBatch);
			}
				
			oldKeyBoardState = keyState;

			spriteBatch.End ();

			base.Draw (gameTime);
		}
	}
}

