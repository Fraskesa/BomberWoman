#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;

#endregion
namespace BomberWomanMonoGame
{
	//This class containes the Main method and is from where we start the application
	static class Program
	{
		//Attributes
		private static Game1 game;

		[STAThread]
		static void Main ()
		{
			game = new Game1 ();
			game.Run ();
		}
	}
}
