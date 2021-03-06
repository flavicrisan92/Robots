﻿using System;
using System.Collections.Generic;

namespace FlaviusTestR.Implementation
{
    public class Rover : IRover
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Orientation { get; set; }

        public Rover(int x, int y, int orientation)
        {
            Orientation = orientation;
            X = x;
            Y = y;
        }

        public void ExecuteCommands(string roverName, string instructions)
        {
            var chars = instructions.ToCharArray();
            foreach (var character in chars)
            {
                var commandToDo = CommandFactory.Build(character.ToString());
                if (commandToDo != null) {
                    var myValues = commandToDo.CalculateOrientation(X, Y, Orientation);
                }
                // OR
                var command = string.Format("FlaviusTestR.Commands.{0}", character.ToString());
                Type type = Type.GetType(command);
                if (type != null)
                {
                    var commandInstance = Activator.CreateInstance(type);
                    var toInvoke = type.GetMethod("CalculateOrientation");
                    object[] parmas = new object[3] { X, Y, Orientation };
                    var result = toInvoke.Invoke(commandInstance, parmas);

                    var values = (Dictionary<string, int>)result;
                    X = values["X"];
                    Y = values["Y"];
                    Orientation = values["Orientation"];
                }
            }
            ShowPosition(roverName);
        }

        public int GetOrientation()
        {
            return Orientation;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        private void ShowPosition(string roverName)
        {
            if (!string.IsNullOrEmpty(roverName))
            {
                Console.WriteLine(string.Format("Rover: {0}", roverName));
            }
            Console.WriteLine(string.Format("Position: X={0}, Y={1}, Orienation={2}", X, Y, PositionsMap.NumberToOrientation[Orientation]));
        }
    }
}