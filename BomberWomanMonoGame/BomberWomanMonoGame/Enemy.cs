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
		Texture2D SpriteMonsterCup;
		Texture2D SpriteMonsterEgg;
		public Rectangle position = new Rectangle(100, 500, 50, 50);
		public Rectangle position2 = new Rectangle(700, 100, 50, 50);
		public Rectangle position3 = new Rectangle(700, 500, 50, 50);

		public Enemy (Texture2D sprite, Texture2D sprite2, Texture2D sprite3)
		{
			SpriteMonsterSun = sprite;
			SpriteMonsterCup = sprite2;
			SpriteMonsterEgg = sprite3;
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
			int randomNumber2 = random.Next(0, 100);
			int randomNumber3 = random.Next(0, 100);

			//changes the position of the enemy accroding to the random generated number
			//MOnsterSun movement
			if (randomNumber < 25)
				position.X -= 5;

			if (randomNumber < 50 && randomNumber > 25)
				position.Y -= 5;

			if (randomNumber < 75 && randomNumber > 50)
				position.X += 5;

			if (randomNumber < 100 && randomNumber > 75)
				position.Y += 5;



			//MonsterCup movement
			if (randomNumber2 < 25)
				position2.X -= 5;

			if (randomNumber2 < 50 && randomNumber2 > 25)
				position2.Y -= 5;

			if (randomNumber2 < 75 && randomNumber2 > 50)
				position2.X += 5;

			if (randomNumber2 < 100 && randomNumber2 > 75)
				position2.Y += 5;

			//Paolo movement
			if (randomNumber3 < 25)
				position3.X -= 20;

			if (randomNumber3 < 50 && randomNumber3 > 25)
				position3.Y -= 20;

			if (randomNumber3 < 75 && randomNumber3 > 50)
				position3.X += 20;

			if (randomNumber3 < 100 && randomNumber3 > 75)
				position3.Y += 20;


			//resets the position of the enemy so it cannot exit the frame/window
			if (position.X > 700)
				position.X = 700;

			if (position.X < 100)
				position.X = 100;

			if (position.Y > 500)
				position.Y = 500;

			if (position.Y < 100)
				position.Y = 100;


			//MonsterCup
			if (position2.X > 700)
				position2.X = 700;

			if (position2.X < 100)
				position2.X = 100;

			if (position2.Y > 500)
				position2.Y = 500;

			if (position2.Y < 100)
				position2.Y = 100;

			//Paolo
			if (position3.X > 700)
				position3.X = 700;

			if (position3.X < 100)
				position3.X = 100;

			if (position3.Y > 500)
				position3.Y = 500;

			if (position3.Y < 100)
				position3.Y = 100;

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
			}
			
		public void Draw (SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (SpriteMonsterSun, position, Color.White);
			spriteBatch.Draw (SpriteMonsterCup, position2, Color.White);
			spriteBatch.Draw (SpriteMonsterEgg, position3, Color.White);
		}
	}
}