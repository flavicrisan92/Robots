using FlaviusTestR.Implementation;
using System;


namespace FlaviusTestR
{
    class Program
    {
        static void Main(string[] args)
        {
            var orientationRover1 = PositionsMap.OrientationToNumber["N"];
            var orientationRover2 = PositionsMap.OrientationToNumber["E"];

            var rover1 = new Rover(1, 2, orientationRover1);
            var rover2 = new Rover(3, 3, orientationRover2);

            rover1.ExecuteCommands("rover1", "1LMLMLMLMM");
            rover2.ExecuteCommands("rover2", "MMRMMRMRRM");
            Console.ReadLine();
        }
    }
}
