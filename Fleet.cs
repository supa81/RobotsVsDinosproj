using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        // MEMBER VARIABLES - WHAT IS HAS
        public List<Robots> fleet;
        Robots R2D2 = new Robots( "R2D2", 100, 250, new Wepons(50));
        Robots T3000 = new Robots( "T3000", 100, 250, new Wepons(70));
        Robots RoboCop = new Robots( "RoboCop", 100, 300, new Wepons(130));
        //constructor - spawn 

        public Fleet()
        {
            fleet = new List<Robots>();
            fleet.Add(R2D2);
            fleet.Add(T3000);
            fleet.Add(RoboCop);

        }


        //member variables - what is can do 



    }
}
