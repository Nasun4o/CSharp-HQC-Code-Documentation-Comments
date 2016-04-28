namespace Empires.Contracts
{
    /// <summary>
    /// This is our indipendance writer that prints our actions on console.
    /// </summary>
    public interface IOutputWriter
    {
        void Print(string message);
    }
}
