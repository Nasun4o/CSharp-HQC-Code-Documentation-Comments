namespace Empires.Contracts
{
    /// <summary>
    /// This interface is extendet by Iattacker and IDestroyeable so now we have Health and AttackDamage.
    /// </summary>
    public interface IUnit : IAttacker, IDestroyable
    {
    }
}
