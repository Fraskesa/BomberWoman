using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BomberWomanMonoGame
{

	public class Bomb
	{
	

		//constructor
		public Bomb (int x, int y, Texture2D sprite)
		{
			this.x = x;
			this.y = y;
			SpriteBomb = sprite;
		}

		private Texture2D SpriteBomb;
		private int x;
		private int y;


		public void Initialize(){
		}

		public void Update(){
		}

		public void Draw(SpriteBatch spriteBatch){

			spriteBatch.Draw (SpriteBomb, new Rectangle (x, y, 50, 50), Color.White);
		}



	}
}

