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
		//private int x;
		//private int y;
		public Rectangle bombPosition;// = new Rectangle (200,200,50,50);
		private BomberWoman myBomberWoman;
		private KeyboardState oldKeyBoardState;
		private double countdown = 3000; //ms
		public bool inGame = true;

		// Constructor
		public Bomb (Texture2D sprite, int x, int y)
		{
			//this.x = x;
			//this.y = y;
			bombPosition = new Rectangle (x, y, 50, 50);
			SpriteBomb = sprite;

		}

		public void Initialize(){
		}

		public void Update(GameTime gameTime)
		{

			Console.WriteLine (gameTime.ElapsedGameTime.TotalMilliseconds);
			if (inGame == true)
				countdown = countdown - gameTime.ElapsedGameTime.TotalMilliseconds;
			if (countdown < 0)
				inGame = false;


		}

		public void Draw(SpriteBatch spriteBatch){
			Console.WriteLine ("Jamen " + bombPosition.X);

				spriteBatch.Draw (SpriteBomb, bombPosition, Color.White);
			Console.WriteLine ("I think the bomb is drawn");
		}
	}
}

