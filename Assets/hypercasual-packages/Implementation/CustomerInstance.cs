using Hypercasual.Framework;
using UnityEngine;

namespace Hypercasual.Implementation
{
    public class CustomerInstance : MonoBehaviour, ICustomer, IWalkable
    { 
        public Vector3 currentPosition => _currentPosition;
        private Vector3 _currentPosition;

        private Vector3 _destination;

        public void MakeOrder(IOrder order)
        {
            throw new System.NotImplementedException();
        }

        public void ReceiveOrder(IOrder order)
        {
            throw new System.NotImplementedException();
        }

        public void Walk(Vector3 destination)
        {
            _destination = destination;
        }

        void Update()
        {
            transform.position = Vector3.Lerp(transform.position, Vector3.up * 1.25f, Time.deltaTime * 1f);
        }
    }
}