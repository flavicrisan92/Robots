using System.Collections.Generic;

namespace FlaviusTestR.Commands
{
    public abstract class Command
    {
        public abstract Dictionary<string, int> CalculateOrientation(int X, int Y, int Orientation);

        public Dictionary<string, int> GetResult(int X, int Y, int Orientation)
        {
            var result = new Dictionary<string, int>
            {
                { "X", X },
                { "Y", Y },
                { "Orientation", Orientation }
            };
            return result;
        }
    }
}