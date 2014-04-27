using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace BomberWomanMonoGame
{
	/// <summary>
	/// Write a summary here
	/// </summary>
	public class BomberWoman : GameFigure
	{
		public BomberWoman ()
		{

		}

		//"virtual" makes it possible to access methods in other classes 
		public virtual void LoadContent()
		{

		}

		public virtual void UnloadConent()
		{

		}

		public virtual void Update (GameTime gameTime)
		{
			KeyboardState keyState = Keyboard.GetState ();

			if (keyState.IsKeyDown (Keys.Down)) 
			{
				position.Y += 5;
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

		public virtual void Draw (GameTime gameTime)
		{

		}
	}
}

