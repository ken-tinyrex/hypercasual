namespace Hypercasual.Framework
{
    public interface IWorker 
    {
        void TakeOrder(IOrder order);
        void DeliverOrder(IOrder order);
    }
}