namespace FlaviusTestR
{
    public interface IRover
    {
        int GetX();
        int GetY();
        int GetOrientation();
        void ExecuteInstructions(string roverName, string instructions);         
    }
}