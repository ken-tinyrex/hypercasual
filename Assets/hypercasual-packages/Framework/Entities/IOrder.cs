namespace Hypercasual.Framework
{
    public interface IOrder 
    {
        IOrderData orderData { get; }
        int count { get; }
    }
}