﻿namespace FlaviusTestR.Implementation
{
    public interface IRover
    {
        int GetX();
        int GetY();
        int GetOrientation();
        void ExecuteCommands(string roverName, string instructions);         
    }
}