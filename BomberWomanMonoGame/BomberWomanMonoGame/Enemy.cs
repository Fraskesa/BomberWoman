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
	public class Enemy : GameFigure
	{
		public Enemy ()
		{
		}

		public void Update (GameTime gametime)
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



	}
}