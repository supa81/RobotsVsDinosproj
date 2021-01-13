using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Dinosaurs
    {

        // MEMBER VARIABLES - WHAT IS HAS 
        //TYPE 
        //HEALTH 
        //ENERGY 
        //ATTACK POWER 
        public string type;
        public int health;
        public int energy;
        public int attackPower;
       
        // CONSTRUCTOR -  SPAWNING IN 
        public Dinosaurs(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        //MEMBER METHODS - WHAT IT CAN DO 

        //AttackRobots(//robots objects)
            // .notation to access parameters for classes 

        public void AttackRobots(Robots robot)
        {

            robot.health -= attackPower;

        }
       
        


    }
}
