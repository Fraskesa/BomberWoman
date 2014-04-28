using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace BomberWomanMonoGame
{

	public class GameScreen
	{

		protected ContentManager content;

		public GameScreen ()
		{

		}


		public virtual void LoadContent ()
		{
			content = new ContentManager (ScreenManager.Instance.Content.ServiceProvider, "Content");
		}

		public virtual void UnloadContent ()
		{
			content.Unload ();
		}

		public virtual void Update (GameTime gameTime)
		{

		}

		public virtual void Draw (SpriteBatch spriteBatch)
		{

		}


	}
}

