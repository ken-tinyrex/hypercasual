namespace Hypercasual.Framework
{
    public interface IGenerator
    {
        IGeneratorData generatorData { get; }
        IOrderData orderData { get; }
        
        void GenerateOrder(IOrder order);
        void ShowStats();
        void Upgrade();
    }
}