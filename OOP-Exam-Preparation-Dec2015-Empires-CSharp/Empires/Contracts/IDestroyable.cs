namespace Empires.Contracts
{
    /// <summary>
    /// It's implements on everything that can be Killed or Destroyed.
    /// </summary>
    public interface IDestroyable
    {
        // Added public setter
        int Health { get; set; }
    }
}
