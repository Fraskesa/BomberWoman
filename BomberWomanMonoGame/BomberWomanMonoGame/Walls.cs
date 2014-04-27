using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
//using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace BomberWomanMonoGame
{
	/// <summary>
	/// The Walls are the hedges that can be blown by the blast of the bombs. 
	/// The hedges sometimes have hidden objects that are only revealed when they have been removed.
	/// </summary>
	public class Walls : StaticObject
	{

		public Walls ()
		{
			//private static Walls instance;
			//public Vector2 Dimensions {private set; GetType; }
				 

			private Texture2D SpriteHedge;

			public virtual void LoadContent()
			{
				SpriteHedge = Content.Load<Texture2D> ("hedge");
			}

			public virtual void UnloadConent()
			{
			Content.Unload ();
			}

			public virtual void Update (GameTime gameTime)
			{

			}

			public virtual void Draw (SpriteBatch spritebatch)
			{
				spriteBatch.Begin ();
				spriteBatch.Draw (SpriteHedge, new Rectangle (50, 50, 800, 600), Color.White);
				spriteBatch.End ();
			}
		}
	}
}

