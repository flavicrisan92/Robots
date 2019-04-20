using System.Collections.Generic;

namespace FlaviusTestR.Commands
{
    public interface ICommand
    {
        Dictionary<string, int> CalculateOrientation(int Orientation, int X, int Y);
    }
}