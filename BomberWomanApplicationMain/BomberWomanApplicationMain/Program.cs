using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberWomanApplicationMain
{
    class BomberWoman
    {
       public float speed; //can be altered by picking up items by multiplying wiht e.g. 1.25
       public bool alive; // in bomberman there is no health bar, the either you are alive or you are dead.
       public uint bombs; //number of bombs available
       public bool bombcontrol; //if BW can control bombs explosions or nor
       public int lives; //the numbers of lives left (not including the one in use)
       public int blast; //the energy of the blast is how long the explosion will reach
       public float xpos; //checking where BW is and makes sure she can't fly over objects.
       public float ypos;

        //need a method to set a bomb
        //need a method that makes to bomb explode given that BW can control it
        //a method0 that checks if the blast hit an enemy, though this might just be opposite - if an enemy was hit by a blast.
    }

    class Enemy
    {
        //needs speed and some AI system I think
        public float xpos;
        public float ypos;
        public bool alive;    
    }

    class Bomb
    {
        //The bomb should have a timer or be controlled by BW
        //a blast length
        //a spawner
        //some graphics
        public bool inScene;
        public int blast; //the energy of the blast is how long the explosion will reach
    }
  
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
