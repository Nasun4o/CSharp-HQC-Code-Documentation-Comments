namespace Empires.Contracts
{
    using System.Collections.Generic;

    using Enums;

    /// <summary>
    /// This is Game Database here we save anything that we have created.
    /// </summary>
    public interface IEmpiresData
    {
        IEnumerable<IBuilding> Buildings { get; }

        void AddBuilding(IBuilding building);

        IDictionary<string, int> Units { get; }

        void AddUnit(IUnit unit);

        IDictionary<ResourceType, int> Resources { get; } 
    }
}
