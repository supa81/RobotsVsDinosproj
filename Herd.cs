using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Herd
    {

        // MEMBER VARIABLES - WHAT IS HAS
        public List<Dinosaurs> herd;


        Dinosaurs LongFoot = new Dinosaurs("Tank", 100, 100, 100);
        Dinosaurs Ducky = new Dinosaurs("Tank", 200, 200, 200);
        Dinosaurs Petrie = new Dinosaurs("Tank", 300, 300, 300);

        //constructor - spawn
        public Herd()
        {
            herd = new List<Dinosaurs>();

            herd.Add(Petrie);
            herd.Add(LongFoot);
            herd.Add(Ducky);
           
        }



        //member METHODS - what is can do 




    }
}
