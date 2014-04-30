using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace BomberWomanMonoGame
{
	public class Bomb
	{
		// Attributes
		private Texture2D SpriteBomb;
		private Texture2D SpriteWalkDownStill;
		private int x;
		private int y;
		public Rectangle bombPosition = new Rectangle (200,200,50,50);
		private BomberWoman myBomberWoman;
		private KeyboardState oldKeyBoardState;


		// Constructor
		public Bomb (Texture2D sprite)
		{//int x, int y, 
			//this.x = x;
			//this.y = y;
			SpriteBomb = sprite;

		}

		public void Initialize(){
		}

		public void Update(GameTime gameTime)
		{
			//Allows for user keyboard inputs
			KeyboardState keyState = Keyboard.GetState ();

			if (true) 
			{
				if (keyState.IsKeyUp (Keys.B) && oldKeyBoardState.IsKeyDown (Keys.B)) 
				{
					myBomberWoman = new BomberWoman (SpriteWalkDownStill);
				}
			}
				
			if (myBomberWoman != null) 
			{
				myBomberWoman.Update (gameTime);
				bombPosition.X = myBomberWoman.position.X;
				bombPosition.Y = myBomberWoman.position.Y;
				Console.WriteLine ("In bomb update " + myBomberWoman.position.X);

			}



			oldKeyBoardState = keyState;
		}

		public void Draw(SpriteBatch spriteBatch){

			spriteBatch.Draw (SpriteBomb, bombPosition, Color.White);
			Console.WriteLine ("I think the bomb is drawn");
		}
	}
}

