using System;
using System.Collections.Generic;

namespace FlaviusTestR
{
    public sealed class PositionsMap
    {
        private static readonly Lazy<PositionsMap> lazy = 
            new Lazy<PositionsMap>(() => new PositionsMap());

        public static PositionsMap Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public static Dictionary<string, int> OrientationToNumber = new Dictionary<string, int>
            {
                { "N", 0 },
                { "E", 1 },
                { "S", 2 },
                { "V", 3 }
            };

        public static Dictionary<int, string> NumberToOrientation = new Dictionary<int, string>
            {
                { 0, "N" },
                { 1, "E" },
                { 2, "S" },
                { 3, "V" }
            };
    }
}
