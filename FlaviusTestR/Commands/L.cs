using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaviusTestR.Commands
{
    public class L: Command
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

            result.Add("X", X);
            result.Add("Y", Y);
            result.Add("Orientation", Orientation);
            return result;

        }
    }
}
