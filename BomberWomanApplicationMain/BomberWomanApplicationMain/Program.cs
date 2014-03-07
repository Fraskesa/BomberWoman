using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberWomanApplicationMain
{
    class BomberWoman
    {
        float speed; //can be altered by picking up items by multiplying wiht e.g. 1.25
        bool alive; // in bomberman there is no health bar, the either you are alive or you are dead.
        uint bombs; //number of bombs available
        bool bombcontrol; //if BW can control bombs explosions or nor
        int blast; //the energy of the blast is how long the explosion will reach
        float xpos; //checking where BW is and makes sure she can't fly over objects.
        float ypos;

        //need a function to set a bomb
        //need a function that makes to bomb explode given that BW can control it
        //a function that checks if the blast hit an enemy, though this might just be opposite - if an enemy was hit by a blast.
    }

    class Enemy
    {
        //needs speed and some AI system I think
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
