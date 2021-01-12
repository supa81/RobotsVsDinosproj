using System;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Robots R2D2= new Robots("R2D2", 100, 100, 100, 300, 100);
            Robots T3000 = new Robots("T3000", 200, 200, 200, 300, 100);
            Robots RoboCop = new Robots("RoboCop", 300, 300,300,300, 100);
            Dinosaurs LongFoot = new Dinosaurs("Tank", 100, 100, 100);
            Dinosaurs Ducky = new Dinosaurs("Tank", 200, 200, 200);
            Dinosaurs Petrie = new Dinosaurs("Tank", 300 ,300 ,300);

        }
    }
}
