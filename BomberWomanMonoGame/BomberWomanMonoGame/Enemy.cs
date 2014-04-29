using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace BomberWomanMonoGame
{
	public class Enemy
	{
		Random random = new Random();
		Texture2D SpriteMonsterSun;
		public Rectangle position = new Rectangle(750, 550, 50, 50);

		public Enemy (Texture2D sprite)
		{
			SpriteMonsterSun = sprite;
		}

		public void Initialize()
		{

		}

		public void Update (GameTime gametime)
		{
			//allows for user keyboard inputs
			KeyboardState keyState = Keyboard.GetState ();

			//generates a random number between 0 and 100
			int randomNumber = random.Next(0, 100);

			//changes the position of the enemy accroding to the random generated number
			if (randomNumber < 25)
				position.X -= 5;

			if (randomNumber < 50 && randomNumber > 25)
				position.Y -= 5;

			if (randomNumber < 75 && randomNumber > 50)
				position.X += 5;

			if (randomNumber < 100 && randomNumber > 75)
				position.Y += 5;


			//resets the position of the enemy so it cannot exit the frame/window
			if (position.X > 700)
				position.X = 700;

			if (position.X < 100)
				position.X = 100;

			if (position.Y > 500)
				position.Y = 500;

			if (position.Y < 100)
				position.Y = 100;

			//the user keyboard inputs are set to W, A, S, and D. The position is changed with 5 pixels everytime
			if (keyState.IsKeyDown (Keys.S)) 
				{
					position.Y += 5;
				}

				if (keyState.IsKeyDown (Keys.W)) 
				{
					position.Y -= 5;
				}

				if (keyState.IsKeyDown (Keys.A)) 
				{
					position.X -= 5;
				}

				if (keyState.IsKeyDown (Keys.D)) 
				{
					position.X += 5;
				}
				Console.WriteLine ("JAAAAAAA" + position.X);
			}
			
		public void Draw (SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (SpriteMonsterSun, position, Color.White);
		}
	}
}