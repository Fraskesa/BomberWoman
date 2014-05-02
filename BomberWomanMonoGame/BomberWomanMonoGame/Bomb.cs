using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace BomberWomanMonoGame
{
	//This class is where the bomb and the blast of the bomb is updated and drawn. It is the main functionality of bomberWoman to place bombs where she is placed
	public class Bomb
	{
		//Attributes
		//Textures for the bomb and blast images
		private Texture2D SpriteBomb;
		private Texture2D SpriteBlast;

		//Used for the boms position
		private Rectangle bombPosition;

		//Timer and if on screen bool for the bomb (time is in miliseconds)
		private double bombTimer = 2000; 
		public bool bombOnScreen = true;

		//Timer and if on screen bool for the blast (time is in miliseconds)
		public double blastTimer = 750;
		public bool blastOnScreen = false;

		// Constructor
		public Bomb (Texture2D sprite, Texture2D sprite2, int x, int y)
		{
			bombPosition = new Rectangle (x, y, 50, 50);
			SpriteBomb = sprite;
			SpriteBlast = sprite2;
		}

		//Here we update the bomb-timer and switches between the bomb and the blast
		public void Update(GameTime gameTime)
		{
			if (bombOnScreen == true)
				bombTimer = bombTimer - gameTime.ElapsedGameTime.TotalMilliseconds;

			if (bombTimer < 1) {
				blastOnScreen = true;
				bombOnScreen = false;
			}
		}

		//Here we update the blast-timer
		public void blastUpdate(GameTime gameTime)
		{
			if (blastOnScreen)
				blastTimer -= gameTime.ElapsedGameTime.TotalMilliseconds;

			if (blastTimer < 1)
				blastOnScreen = false;
		}

		//Drawing of the bomb
		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (SpriteBomb, bombPosition, Color.White);
		}

		//Drawing the blast in the vacinity of where the bomb was placed
		public void blastDraw(SpriteBatch spriteBatch)
		{
				spriteBatch.Draw(SpriteBlast, new Rectangle (bombPosition.X-50, bombPosition.Y, 50, 50),Color.White);//x-50
				spriteBatch.Draw(SpriteBlast, new Rectangle (bombPosition.X+50, bombPosition.Y, 50, 50),Color.White); //x+50
				spriteBatch.Draw(SpriteBlast, new Rectangle (bombPosition.X, bombPosition.Y-50, 50, 50),Color.White); //y-50
				spriteBatch.Draw(SpriteBlast, new Rectangle (bombPosition.X, bombPosition.Y+50, 50, 50),Color.White); //y+50
				spriteBatch.Draw(SpriteBlast, new Rectangle (bombPosition.X, bombPosition.Y, 50, 50),Color.White);
		}
	}
}

