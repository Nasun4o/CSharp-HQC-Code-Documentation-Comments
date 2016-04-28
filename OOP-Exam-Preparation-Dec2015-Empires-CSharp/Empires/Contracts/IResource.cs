namespace Empires.Contracts
{
    using Enums;

    /// <summary>
    /// This is the different types of Resources and his Quantity.
    /// </summary>
    public interface IResource
    {
        ResourceType ResourceType { get; }

        int Quantity { get; }
    }
}
