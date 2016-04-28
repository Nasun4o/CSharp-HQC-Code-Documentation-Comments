namespace Empires.Contracts
{
    using Enums;

    /// <summary>
    /// This is our method to Create Resource that take Type and Quantity.
    /// </summary>
    public interface IResourceFactory
    {
        IResource CreateResource(ResourceType resourceType, int quantity);
    }
}
