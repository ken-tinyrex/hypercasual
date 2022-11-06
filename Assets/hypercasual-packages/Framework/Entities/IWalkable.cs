using UnityEngine;

namespace Hypercasual.Framework
{
    public interface IWalkable
    {
        Vector3 currentPosition { get; }

        void Walk(Vector3 destination);
    }
}