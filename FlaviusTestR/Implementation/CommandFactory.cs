using FlaviusTestR.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaviusTestR.Implementation
{
    public static class CommandFactory
    {
        public static Command Build(string key)
        {
            switch (key)
            {
                case "L":
                    return new L();
                case "M":
                    return new M();
                case "R": return new R();

                default:
                    return null;
            }
        }
    }
}
