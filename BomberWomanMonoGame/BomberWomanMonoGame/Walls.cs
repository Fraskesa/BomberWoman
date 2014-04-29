﻿using System;
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
			//Draws the vertical center line of hedges
			for (int i = 100; i < 550; i += 50) 
			{
				spriteBatch.Draw (SpriteHedge, new Rectangle (400, i, 50, 50), Color.White);
			}

			//Draws the horisontal center line of hedges
			for (int i = 100; i < 750; i += 50) 
			{
				spriteBatch.Draw (SpriteHedge, new Rectangle (i, 300, 50, 50), Color.White);
			}

			//Here the rest of the randomly scattered hedges are drawn. 
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
			spriteBatch.Draw (SpriteHedge, new Rectangle (150, 100, 50, 50), Color.White);
		}
	}
}

