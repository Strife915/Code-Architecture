using System.Collections.Generic;
using UnityEngine;
using Utilities;

namespace CodeArchitecture.Visitor
{
    public class Hero : MonoBehaviour, IVisitable
    {
        List<IVisitable> _visitables = new List<IVisitable>();
        void Start()
        {
            _visitables.Add(gameObject.GetOrAdd<HealthComponent>());
            _visitables.Add(gameObject.GetOrAdd<ManaComponent>());
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IVisitable visitable in _visitables)
            {
                visitable.Accept(visitor);
            }
        }
    }
}