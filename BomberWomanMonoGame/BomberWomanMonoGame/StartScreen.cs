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

		Texture2D SpriteMonsterSun;
		Texture2D SpriteBombsUp;
		public Rectangle position = new Rectangle(650, 450, 50, 50);
		public Rectangle bombPosition = new Rectangle ();

		Random random = new Random();


		public StartScreen ()
		{
		}


		public override void LoadContent()
		{
			base.LoadContent ();

			SpriteMonsterSun = content.Load<Texture2D> ("monsterSun(1)");
			SpriteBombsUp = content.Load<Texture2D>("BombsUp(1)");
		}

		public override void UnloadContent()
		{
			base.UnloadContent ();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update (gameTime);

			int randomNumber = random.Next(0, 100);





			if (randomNumber < 25)
				position.X -= 5;

			if (randomNumber < 50 && randomNumber > 25)
				position.Y -= 5;

			if (randomNumber < 75 && randomNumber > 50)
				position.X += 5;

			if (randomNumber < 100 && randomNumber > 75)
				position.Y += 5;
				


			if (position.X > 700)
				position.X = 700;

			if (position.X < 0)
				position.X = 0;

			if (position.Y > 500)
				position.Y = 500;

			if (position.Y < 0)
				position.Y = 0;
				
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
			

		public override void Draw(SpriteBatch spriteBatch)
		{
			int randomNumber = random.Next (1, 100);

			spriteBatch.Draw (SpriteMonsterSun, position, Color.White);


			// The problem with this is that when it is drawn, it is over-draw again next frame by nothing.
			if (randomNumber == 1) 
			{
				bombPosition = position;
				spriteBatch.Draw (SpriteBombsUp, bombPosition, Color.White);
			}

		}

	}
}

