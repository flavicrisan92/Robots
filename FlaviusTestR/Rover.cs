using System;

namespace FlaviusTestR
{
    public class Rover : IRover
    {
        private int Orientation { get; set; }
        private int X { get; set; }
        private int Y { get; set; }
        private PositionsMap Positions { get; set; }
        
        public Rover(int x, int y, int firstOrientation, PositionsMap positions)
        {
            Positions = positions;
            Orientation = firstOrientation;
            X = x;
            Y = y;
        }

        public void ExecuteInstructions(string roverName, string instructions)
        {
            var chars = instructions.ToCharArray();
            foreach (var character in chars)
            {
                if (character == 'M')
                {
                    Move();
                }
                else
                {
                    ChangeOrientation(character);
                }
            }

            ShowPosition(roverName);
        }

        public void ChangeOrientation(char key)
        {
            if (key == 'L')
            {
                DecreaseOrientation();
            }
            else if (key == 'R')
            {
                IncreaseOrientation();
            }
        }

        public void Move()
        {
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
        }

        public void IncreaseOrientation()
        {
            if (Orientation == 3)
            {
                Orientation = 0;
            }
            else
            {
                Orientation++;
            }
        }

        public void DecreaseOrientation()
        {
            if (Orientation == 0)
            {
                Orientation = 3;
            }
            else
            {
                Orientation--;
            }
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
            Console.WriteLine(string.Format("Position: X={0}, Y={1}, Orienation={2}", X, Y, Positions.NumberToOrientation[Orientation]));
        }
    }
}