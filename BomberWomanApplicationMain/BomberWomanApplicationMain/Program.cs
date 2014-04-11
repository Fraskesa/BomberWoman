using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberWomanApplicationMain
{
	//giidjrngd
    class GameFigure
    {
        float xpos; //checking where the figure is, and makes sure it cant fly over objects
        float ypos;
        bool alive = true;
        float speed; //can be altered by picking up items by multiplying with e.g. 1.25
    }
    
    class BomberWoman : GameFigure
    {
		int lives; //the number of lives left
        uint bombs; //number of bombs available
        bool bombcontrol; //if BW can control bombs explosions or nor
        int blast; //the energy of the blast is how long the explosion will reach


        //need a function to set a bomb
        //need a function that makes to bomb explode given that BW can control it
        //a function that checks if the blast hit an enemy, though this might just be opposite - if an enemy was hit by a blast.
    }

    class Enemy : GameFigure
    {
        //needs speed and some AI system I think
		//Just testing something

        public void Collision()
        {
			//      if (BomberWoman.xpos == Enemy.xpos && BomberWoman.ypos == Enemy.ypos){
			//    BomberWoman.lives -= 1;

                //Restart level
			//}    

		//   if(BomberWoman.lives < 1)
		//       BomberWoman.alive = false;
                
                //Game over
		// }

	//		public void Update (){
		
		
		}

	}

    class Bomb
    {
        //The bomb should have a timer or be controlled by BW
        //a blast length
        //a spawner
        //some graphics
        int blast; //the energy of the blast is how long the explosion will reach
    }



  
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
