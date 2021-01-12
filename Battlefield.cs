using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //MEMBER VARIABLES WHAT IT HAS 
        // warzone
       
        public string warZone;
            
       





        //CONSTRUCTOR SPAWNning in ? 
        public void WarZone( string warZone)
        {
            this.warZone = warZone;

        }

        //MEMBER METHODS WHAT IT CAN DO
       //host the battle 
       //the battle takes place in warzomne
       //enemeys attack until either side wins. 

        public void WarZoneMap(Dinosaurs dinosaur, Robots robot)
        {
            dinosaur.AttackRobots(dinosaur, robot);
            {
                if (dinosaur.health < robot.sword.attackPower)
                {
                    dinosaur.takeDamage = dinosaur.health - robot.sword.attackPower;
                }
            }

            robot.AttackDinosaurs(robot, dinosaur);
            {

                if (robot.health < dinosaur.attackPower)
                {
                    robot.takeDamage = robot.health - dinosaur.attackPower;
                }
                else if (dinosaur.health < robot.sword.attackPower)
                {
                    dinosaur.takeDamage = dinosaur.health - robot.sword.attackPower;
                }

            }



              
                


        }


    }
}
