using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
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
		//A method that randomly places hedges in the game but!!!
		// the hedges cannot be placed on other things or 2 blocks near the player and the enemies.
		//A method that checks if there are more hedges left in the game
		//A method that checks if one or more hedges are blown (and what the coordinates are)


		public virtual void LoadContent()
		{
		}

		public virtual void UnloadConent()
		{
			//content.Unload ();
		}

		public virtual void Update (GameTime gameTime)
		{

		}

		public virtual void Draw (SpriteBatch spritebatch)
		{

		}

			public Walls ()
		{
			 

		}
	}
}

