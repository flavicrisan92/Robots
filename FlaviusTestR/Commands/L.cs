using System.Collections.Generic;

namespace FlaviusTestR.Commands
{
    public class L : Command
    {
        public override Dictionary<string, int> CalculateOrientation(int X, int Y, int Orientation)
        {
            var result = new Dictionary<string, int>();
            if (Orientation == 0)
            {
                Orientation = 3;
            }
            else
            {
                Orientation--;
            }

            return GetResult(X, Y, Orientation);
        }
    }
}
