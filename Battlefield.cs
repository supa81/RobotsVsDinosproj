using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //MEMBER VARIABLES
        //create your fleet object 
        //create your herd object
        //robot attack dino and vice versa
        //side wins when health of all objects in fleet/herd are 0
        //example dino to attack robot-- robotobjectname.attack(dinoobjectname) 
        //Console.WriteLine(the dinos health is now ###

        public Fleet fleet;
        public Herd herd;


        //CONSTRUCTOR SPAWNning in ? 
        public Battlefield(Fleet fleet, Herd herd)
        {

            fleet = new Fleet();
            herd = new Herd();


        }

        //MEMBER METHODS WHAT IT CAN DO

        
            //i want specific robots to attack dinos and vise versa
            //i want one side to win when wever one team reaches 0
          
        public void RunGame()
        {

            fleet.fleet[0].AttackDinosaurs(herd.herd[0]);
            fleet.fleet[1].AttackDinosaurs(herd.herd[1]);
            fleet.fleet[2].AttackDinosaurs(herd.herd[2]);
            herd.herd[0].AttackRobots(fleet.fleet[0]);
            herd.herd[1].AttackRobots(fleet.fleet[1]);
            herd.herd[2].AttackRobots(fleet.fleet[2]);
          
        }
        
        
       //enemeys attack until either side wins. 
       






        
	

	}








        //public void WarZoneMap(Dinosaurs dinosaur, Robots robot)
        //{
        //    dinosaur.AttackRobots(dinosaur, robot);
        //    {
        //        if (dinosaur.health < robot.sword.attackPower)
        //        {
        //            dinosaur.takeDamage = dinosaur.health - robot.sword.attackPower;
        //        }
        //    }

        //    robot.AttackDinosaurs(robot,dinosaur);
        //    {

        //        if (robot.health < dinosaur.attackPower)
        //        {
        //            robot.takeDamage = robot.health - dinosaur.attackPower;
        //        }
        //        else if (dinosaur.health < robot.sword.attackPower)
        //        {
        //            dinosaur.takeDamage = dinosaur.health - robot.sword.attackPower;
        //        }

    }



              
                
