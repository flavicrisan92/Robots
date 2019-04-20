using System;

namespace FlaviusTestR
{
    class Program
    {
        static void Main(string[] args)
        {
            var orientationRover1 = PositionsMap.OrientationToNumber["N"];
            var orientationRover2 = PositionsMap.OrientationToNumber["E"];

            IRover rover1 = new Rover(1, 2, orientationRover1);
            IRover rover2 = new Rover(3, 3, orientationRover2);

            rover1.ExecuteInstructions("rover1", "LMLMLMLMM");
            rover2.ExecuteInstructions("rover2", "MMRMMRMRRM");
            Console.ReadLine();
        }
    }
}
