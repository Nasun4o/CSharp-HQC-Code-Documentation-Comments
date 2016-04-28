namespace Empires.Contracts
{
    /// <summary>
    /// It's implemented by attacking Unit.
    /// </summary>
    public interface IAttacker
    {
        int AttackDamage { get; }
    }
}
