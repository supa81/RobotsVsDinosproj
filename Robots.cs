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
        int maxHealth;
        int damage;



        // CONSTRUCTOR -  SPAWNING IN 
        public Robots(string name, int maxHealth, int health, int powerLevel, string sword, int attackPower )
        {

            this.name = name;
            this.maxHealth = maxHealth;
            this.powerLevel = powerLevel;
            this.sword = sword;
            this.attackPower = attackPower;
            this.health = health;


        }
        //MEMBER METHODS - WHAT IT CAN DO 

        public void AttackDinosaurs(Dinosaurs dinosaurs)
        {
          int Maxhealth = damage - health
        }

        public void RobotsLoseHealth()












    }

}
