using System.Collections.Generic;
using UnityEngine;
using Utilities;

namespace CodeArchitecture.Visitor
{
    public class IntrusiveHero : MonoBehaviour, IVisitable
    {
        List<IVisitable> _visitables = new List<IVisitable>();

        void Start()
        {
            _visitables.Add(gameObject.GetOrAdd<IntrusiveHealthComponent>());
            _visitables.Add(gameObject.GetOrAdd<IntrusiveManaComponent>());
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