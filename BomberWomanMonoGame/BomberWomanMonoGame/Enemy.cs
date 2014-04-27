using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace BomberWomanMonoGame
{
	/// <summary>
	/// Write a summary here
	/// </summary>
	public class Enemy : GameFigure
	{
		SpriteBatch spriteBatch;

		private Texture2D SpriteMonsterSun;

		public Rectangle position = new Rectangle(650, 450, 50, 50);


		public Enemy ()
		{
		}

		public virtual void Update (GameTime gametime)
		{

			KeyboardState keyState = Keyboard.GetState ();

			if (keyState.IsKeyDown (Keys.Down)) 
			{
				position.X += 5;
			}

			if (keyState.IsKeyDown (Keys.Up)) 
			{
				position.Y -= 5;
			}

			if (keyState.IsKeyDown (Keys.Left)) 
			{
				position.X -= 5;
			}

			if (keyState.IsKeyDown (Keys.Right)) 
			{
				position.X += 5;
			}
		}

		public virtual void Draw(GameTime gameTime)
		{

			spriteBatch.Begin ();
			spriteBatch.Draw (SpriteMonsterSun, position, Color.White);
			spriteBatch.End ();

		}



	}
}