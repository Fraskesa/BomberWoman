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
		private Texture2D SpriteBlast;
		//private int x;
		//private int y;
		public Rectangle bombPosition;// = new Rectangle (200,200,50,50);
		private BomberWoman myBomberWoman;
		private KeyboardState oldKeyBoardState;
		private double countdown = 3000; //ms
		public bool inGame = true;
		public bool blast = true;
		public double blastTime = 3000;

		// Constructor
		public Bomb (Texture2D sprite, Texture2D sprite2, int x, int y)
		{
			//this.x = x;
			//this.y = y;
			bombPosition = new Rectangle (x, y, 50, 50);
			SpriteBomb = sprite;
			SpriteBlast = sprite2;

		}

		public void Initialize(){
		}

		public void Update(GameTime gameTime)
		{

			Console.WriteLine (gameTime.ElapsedGameTime.TotalMilliseconds);
			if (inGame == true)
				countdown = countdown - gameTime.ElapsedGameTime.TotalMilliseconds;
			if (countdown < 1) {
				blast = true;
				inGame = false;

			}
			if (blast)
				blastTime -= gameTime.ElapsedGameTime.TotalMilliseconds;

			if (blastTime < 1)
				blast = false;




		}

		public void Draw(SpriteBatch spriteBatch){
		
			spriteBatch.Draw (SpriteBomb, bombPosition, Color.White);

		}

		public void blastDraw(SpriteBatch spriteBatch){
		
				spriteBatch.Draw(SpriteBlast, new Rectangle (bombPosition.X-50, bombPosition.Y, 50, 50),Color.White);//x-50
				spriteBatch.Draw(SpriteBlast, new Rectangle (bombPosition.X+50, bombPosition.Y, 50, 50),Color.White); //x+50
				spriteBatch.Draw(SpriteBlast, new Rectangle (bombPosition.X, bombPosition.Y-50, 50, 50),Color.White); //y-50
				spriteBatch.Draw(SpriteBlast, new Rectangle (bombPosition.X, bombPosition.Y+50, 50, 50),Color.White); //y+50
			
		}
	}
}

