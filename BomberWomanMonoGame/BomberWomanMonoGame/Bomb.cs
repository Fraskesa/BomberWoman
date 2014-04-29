using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BomberWomanMonoGame
{
	public class Bomb
	{
		// Attributes
		private Texture2D SpriteBomb;
		private int x;
		private int y;
		BomberWoman testWoman;

		// Constructor
		public Bomb (int x, int y, Texture2D sprite)
		{
			this.x = x;
			this.y = y;
			SpriteBomb = sprite;
			//testWoman = new BomberWoman;
		}

		public void Initialize(){
		}

		public void Update(GameTime gameTime)
		{
			//BomberWoman.Update (gameTime);
		}

		public void Draw(SpriteBatch spriteBatch){

			spriteBatch.Draw (SpriteBomb, new Rectangle (x, y, 50, 50), Color.White);
		}
	}
}

