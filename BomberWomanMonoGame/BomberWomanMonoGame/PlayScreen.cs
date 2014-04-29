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
	public class PlayScreen : GameScreen
	{
		Texture2D testPlayScreen;

		public PlayScreen ()
		{

		}
			
		public override void LoadContent()
		{
			base.LoadContent ();

			testPlayScreen = content.Load<Texture2D> ("SpeedUp(1)");
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
			spriteBatch.Draw (testPlayScreen, new Rectangle(0,0,400,350), Color.White);
		}
	}
}

