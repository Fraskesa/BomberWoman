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

	public class Enemy : GameFigure
	{
		//protected ContentManager Content;
		//GraphicsDeviceManager enemyGraphics;
		//SpriteBatch spriteBatch;


		//private Texture2D SpriteMonsterSun;
		//public Rectangle position = new Rectangle(650, 450, 50, 50);


		public Enemy ()
		{

			//enemyGraphics = new GraphicsDeviceManager (this);
			//Content.RootDirectory = "Content";	
		}
		/*
		protected override void Initialize()
		{

		}

		public virtual void LoadContent (ContentManager Content)
		{
			//SpriteMonsterSun = Content.Load<Texture2D> ("monsterSun(1)");
		}

		protected override void UnloadContent ()
		{

		}

		protected override void Update (GameTime gametime)
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

		protected override void Draw(GameTime gameTime)
		{

			//spriteBatch.Begin ();
			//spriteBatch.Draw (SpriteMonsterSun, position, Color.White);
			//spriteBatch.End ();
		
			//base.Draw (gameTime);
		}

*/

	}
}