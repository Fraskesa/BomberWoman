using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BomberWomanMonoGame
{
	public class BomberWoman
	{

		private Texture2D SpriteWalkDownStill;
		public Rectangle position = new Rectangle (100,100,40,40);


		public BomberWoman (Texture2D sprite)
		{
			SpriteWalkDownStill = sprite;
		}
			 
		public void Initialize()
		{
			//position.X = 100;
			//position.Y = 100;
		}

		public void Update(GameTime gameTime)
		{
			KeyboardState keyState = Keyboard.GetState ();

			//Uses keyboard events (right, left, up, down) for controlling BomberWoman
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

			//resets the position of the enemy so it cannot exit the frame/window
			if (position.X > 710)
				position.X = 710;

			if (position.X < 100)
				position.X = 100;

			if (position.Y > 510)
				position.Y = 510;

			if (position.Y < 100)
				position.Y = 100;
				
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			//position.X = 100 + position.X;
			//position.Y = 100 + position.Y;
			spriteBatch.Draw (SpriteWalkDownStill, position, Color.White);
		}
	}
}

