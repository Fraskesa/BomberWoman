using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BomberWomanMonoGame
{
	// The Walls are the hedges that can be blown by the blast of the bombs. 
	// The hedges sometimes have hidden objects that are only revealed when they have been removed.
	public class Walls
	{
		// Attributes
		private Texture2D SpriteHedge;

		// Constructor
		public Walls (Texture2D sprite)
		{
			SpriteHedge = sprite;
		}

		public void Initialize(){
		}

		public void Update(GameTime gameTime)
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
		}
	}
}

