namespace Hypercasual.Framework
{
    public interface ICustomer 
    {
        void MakeOrder(IOrder order);
        void ReceiveOrder(IOrder order);
    }
}