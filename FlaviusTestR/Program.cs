using System;

namespace FlaviusTestR
{
    class Program
    {
        static void Main(string[] args)
        {
            var positionMap = new PositionsMap();
            var orientationRover1 = positionMap.OrientationToNumber["N"];
            var orientationRover2 = positionMap.OrientationToNumber["E"];

            IRover rover1 = new Rover(1, 2, orientationRover1, positionMap);
            IRover rover2 = new Rover(3, 3, orientationRover2, positionMap);

            rover1.ExecuteInstructions("rover1", "LMLMLMLMM");
            rover2.ExecuteInstructions("rover2", "MMRMMRMRRM");
            Console.ReadLine();
        }
    }
}
