namespace Empires.Contracts
{
    /// <summary>
    /// Create Building that produce Resources and Units
    /// </summary>
    public interface IBuilding : IUnitProducer, IResourceProducer, IUpdateable
    {
    }
}
