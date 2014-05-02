using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace BomberWomanMonoGame
{
	//This calss is the character we control - BomberWoman. She is able to run around and place bomb with the arrow-keys and space-bar
	public class BomberWoman
	{
		//Attributes
		private Texture2D SpriteWalkDownStill;
		public Rectangle position = new Rectangle (100,100,40,40);

		//Constructor
		public BomberWoman (Texture2D sprite)
		{
			SpriteWalkDownStill = sprite;
		}
			 
		//Here we update the movement behavior of BomberWoman, and make sure that she cannon walk outside the stone edge of the screen
		public void Update(GameTime gameTime)
		{
			//Allows for keyboard events
			KeyboardState keyState = Keyboard.GetState ();

			//Uses keyboard events (arrow-keys) for controlling BomberWoman
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

			//Resets the position of the enemy so it cannot exit the frame/window
			if (position.X > 710)
				position.X = 710;

			if (position.X < 100)
				position.X = 100;

			if (position.Y > 510)
				position.Y = 510;

			if (position.Y < 100)
				position.Y = 100;
		}

		//Here we draw Bomberwoman with the updated position
		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (SpriteWalkDownStill, position, Color.White);
		}
	}
}

