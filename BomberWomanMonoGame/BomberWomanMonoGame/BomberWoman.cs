using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BomberWomanMonoGame
{

	public class BomberWoman : NonStaticObject
	{

		SpriteBatch spriteBatch;

		private Texture2D SpriteWalkDownStill;

		//Variable used for BomberWoman's position


		public BomberWoman ()
		{
		}
			 
		public virtual void LoadContent()
		{

		}

		public virtual void UnloadConent()
		{

		}

		public virtual void Update (GameTime gameTime)
		{
			//Uses keyboard events (right, left, up, down) for controlling BomberWoman
			//BomberWoman's position is added with 5 pixels(?) by every key press
			KeyboardState keyState = Keyboard.GetState ();


			/*if (keyState.IsKeyDown (Keys.Down)) 
			{
				this.position.Y += 5;
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
			}*/

		}

		public virtual void Draw (GameTime gameTime)
		{
			/*
			spriteBatch.Begin ();
			spriteBatch.Draw (SpriteWalkDownStill, position, Color.White);
			spriteBatch.End ();
			*/
		}
	}
}

