using System.Collections.Generic;

namespace FlaviusTestR.Commands
{
    public class M : Command
    {
        public override Dictionary<string, int> CalculateOrientation(int X, int Y, int Orientation)
        {
            if (Orientation == 0)//North
            {
                Y++;
            }
            else if (Orientation == 1)//East
            {
                X++;
            }
            else if (Orientation == 2)//South
            {
                Y--;
            }
            else if (Orientation == 3)//West
            {
                X--;
            }

           return GetResult(X, Y, Orientation);
        }
    }
}
