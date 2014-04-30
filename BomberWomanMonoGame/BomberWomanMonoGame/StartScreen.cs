using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BomberWomanMonoGame
{
	public class StartScreen : GameScreen
	{

		//Attributes for sprites
		Texture2D SpriteMonsterSun;
		public Rectangle position = new Rectangle(650, 450, 50, 50);
		public Rectangle bombPosition = new Rectangle ();

		Random random = new Random();


		public StartScreen ()
		{
		}


		public override void LoadContent()
		{
			base.LoadContent ();

			//Load in the sprites/images - bomberwoman, enemies, bombs
			SpriteMonsterSun = content.Load<Texture2D> ("monsterSun(1)");

		}

		public override void UnloadContent()
		{
			base.UnloadContent ();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update (gameTime);

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

			if (position.X < 0)
				position.X = 0;

			if (position.Y > 500)
				position.Y = 500;

			if (position.Y < 0)
				position.Y = 0;
				
			//Allows for user keyboard inputs
			KeyboardState keyState = Keyboard.GetState ();

			//The user keyboard inputs are set to W, A, S, and D. The position is changed with 5 pixels everytime
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
			

		public override void Draw(SpriteBatch spriteBatch)
		{
			/*
			int randomNumber = random.Next (1, 100);

			spriteBatch.Draw (SpriteMonsterSun, position, Color.White);
			//spriteBatch.Draw (SpriteBomb, position, Color.White);


			// The problem with this is that when it is drawn, it is over-draw again next frame by nothing.
			if (randomNumber == 1) 
			{
				bombPosition = position;

			}
			*/
		}
	}
}

