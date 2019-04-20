using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaviusTestR.Commands
{
    public class M : Command
    {
        public override Dictionary<string, int> CalculateOrientation(int X, int Y, int Orientation)
        {
            var result = new Dictionary<string, int>();
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

            result.Add("X", X);
            result.Add("Y", Y);
            result.Add("Orientation", Orientation);
            return result;
        }
    }
}
