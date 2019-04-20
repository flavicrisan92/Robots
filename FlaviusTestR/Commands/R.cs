using System.Collections.Generic;

namespace FlaviusTestR.Commands
{
    public class R: Command
    {
        public override Dictionary<string, int> CalculateOrientation(int X, int Y, int Orientation)
        {
            var result = new Dictionary<string, int>();
            if (Orientation == 3)
            {
                Orientation = 0;
            }
            else
            {
                Orientation++;
            }

            return GetResult(X, Y, Orientation);
        }
    }
}
