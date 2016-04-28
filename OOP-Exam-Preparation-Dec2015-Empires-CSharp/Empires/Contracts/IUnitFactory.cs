namespace Empires.Contracts
{
    /// <summary>
    /// Here we create our types of units
    /// </summary>
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}
