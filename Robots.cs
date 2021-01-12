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
        string name;
        int health;
        int powerLevel;
        string sword;
        int attackPower;
        int damage;
        int takeDamage;



        // CONSTRUCTOR -  SPAWNING IN 
        public Robots(string name, int health, int powerLevel, string sword, int attackPower )
        {

            this.name = name;
            this.powerLevel = powerLevel;
            this.sword = sword;
            this.attackPower = attackPower;
            this.health = health;


        }
        //MEMBER METHODS - WHAT IT CAN DO 

        public void AttackDinosaurs(Dinosaurs dinosaurs)
        {
           //.notation from dinos
        }

        public void RobotsLoseHealth(Robots robots)
        {
            if (health < attackPower)
            {
                takeDamage = health - attackPower;
            }
        }












    }

}
