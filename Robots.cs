using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Robots
    {

        // MEMBER VARIABLES - WHAT IS HAS 
        //NAME 
        //HEALTH
        //POWER LEVEL 
        //WEPON (SWORD)
        //ATTACK POWER 
        public string name;
        public int health;
        public int powerLevel;
        public Wepons sword;
        
      
        



        // CONSTRUCTOR -  SPAWNING IN 
        public Robots(string name, int health, int powerLevel, Wepons sword)
        {

            this.name = name;
            this.powerLevel = powerLevel;
            this.sword = sword;
            this.health = health;
            


        }

        //MEMBER METHODS - WHAT IT CAN DO 

        public void AttackDinosaurs(Dinosaurs dinosaur)
        {
            //.notation from dinos
            // .energy - .health from dinos ??
            dinosaur.health -= sword.attackPower;

        }

        
       










    }

}
