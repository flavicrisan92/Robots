using System.Collections.Generic;

namespace FlaviusTestR.Commands
{
    public abstract class Command
    {
        public abstract Dictionary<string, int> CalculateOrientation(int Orientation, int X, int Y);
    }
}