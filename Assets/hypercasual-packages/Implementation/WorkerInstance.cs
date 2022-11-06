using Hypercasual.Framework;
using UnityEngine;

namespace Hypercasual.Implementation
{
    public class WorkerInstance : MonoBehaviour, IWorker, IWalkable
    {
        public Vector3 currentPosition => _currentPosition;
        private Vector3 _currentPosition;

        public void DeliverOrder(IOrder order)
        {
            throw new System.NotImplementedException();
        }

        public void TakeOrder(IOrder order)
        {
            throw new System.NotImplementedException();
        }

        public void Walk(Vector3 destination)
        {
            throw new System.NotImplementedException();
        }
    }
}