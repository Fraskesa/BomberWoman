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
	public class GameOverScreen : GameScreen
	{
		Texture2D testGameOverScreen;

		public GameOverScreen ()
		{

		}

		public override void LoadContent()
		{
			base.LoadContent ();

			testGameOverScreen = content.Load<Texture2D> ("monsterSunDie");
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
			spriteBatch.Draw (testGameOverScreen, new Rectangle(300,300,400,350), Color.White);
		}
	}
}

