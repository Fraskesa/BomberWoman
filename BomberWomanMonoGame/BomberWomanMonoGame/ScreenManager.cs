using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BomberWomanMonoGame
{
	public class ScreenManager
	{
		private static ScreenManager instance;
		public Vector2 Dimensions { private set; get;}
		public ContentManager Content { private set; get;}

		GameScreen currentScreen;

		public static ScreenManager Instance
		{
			get
			{
				if (instance == null)
					instance = new ScreenManager();

				return instance;
			}
		}

		public ScreenManager()
		{
			Dimensions = new Vector2 (850, 650);
			currentScreen = new StartScreen();
		}

		public void LoadContent(ContentManager Content)
		{
			this.Content = new ContentManager(Content.ServiceProvider, "Content");
			currentScreen.LoadContent ();
		}

		public void UnloadContent()
		{
			currentScreen.UnloadContent ();
		}

		public void Update(GameTime gameTime)
		{
			currentScreen.Update (gameTime);
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			currentScreen.Draw (spriteBatch);
		}
	}
}
