using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BomberWomanMonoGame
{
	public class StartScreen : GameScreen
	{

		Texture2D SpriteMonsterSun;
		//public Rectangle position = new Rectangle(650, 450, 50, 50);

		public StartScreen ()
		{
		}


		public override void LoadContent()
		{
			base.LoadContent ();

			SpriteMonsterSun = content.Load<Texture2D> ("monsterSun(1)");
		}

		public override void UnloadContent()
		{
			base.UnloadContent ();
		}

		public override void Update(GameTime gameTime)
		{
			base.Update (gameTime);
		}

		public override void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (SpriteMonsterSun, Vector2.Zero, Color.White);
		}

	}
}

