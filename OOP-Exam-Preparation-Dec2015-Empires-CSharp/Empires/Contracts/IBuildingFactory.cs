namespace Empires.Contracts
{
    /// <summary>
    /// Create different Buildings types with different types Resources and Units.
    /// </summary>
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory);
    }
}
