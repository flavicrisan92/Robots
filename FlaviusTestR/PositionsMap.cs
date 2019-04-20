using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaviusTestR
{
    public class PositionsMap
    {
        public Dictionary<string, int> OrientationToNumber = new Dictionary<string, int>
            {
                { "N", 0 },
                { "E", 1 },
                { "S", 2 },
                { "V", 3 }
            };

        public Dictionary<int, string> NumberToOrientation = new Dictionary<int, string>
            {
                { 0, "N" },
                { 1, "E" },
                { 2, "S" },
                { 3, "V" }
            };
    }
}
