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
        public string tank;
        public int health;
        public int energy;
        public int attackPower;
        public int takeDamage;



        // CONSTRUCTOR -  SPAWNING IN 
        public Dinosaurs(string tank, int health, int energy, int attackPower)
        {
            this.tank = tank;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;





        }





        //MEMBER METHODS - WHAT IT CAN DO 

        //AttackRobots(//robots objects)
            // .notation to access parameters for classes 

        public void AttackRobots(Dinosaurs dinosaur, Robots robot)
        {

            robot.health -= attackPower;

        }
        public void DinosaursLoseHealth(Robots robot)
        {
            if (health < robot.attackPower)
            {
                takeDamage = health - attackPower;
                Console.WriteLine(" Your taking damage ");
            } 
        }
        


    }
}
