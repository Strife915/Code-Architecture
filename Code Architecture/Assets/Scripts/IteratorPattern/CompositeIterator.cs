using System.Collections.Generic;
using CodeArchitecture.Iterator;
using UnityEngine;

namespace CodeArchitecture.Composite
{
    public class CompositeIterator : IIterator
    {
        Stack<IIterator> _stack = new Stack<IIterator>();

        public CompositeIterator(IIterator iterator) {
            _stack.Push(iterator);
        }

        public object Next() {
            if (HasNext())
            {
                IIterator iterator = _stack.Peek();
                MenuComponent component = (MenuComponent)iterator.Next();
                if (component is Menu)
                {
                    _stack.Push(component.CreateIterator());
                }

                return component;
            }
            else
            {
                return null;
            }
        }

        public bool HasNext() {
            if (_stack.Count == 0)
            {
                return false;
            }
            else
            {
                IIterator iterator = _stack.Peek();
                if (!iterator.HasNext())
                {
                    _stack.Pop();
                    return HasNext();
                }
                else
                {
                    return true;
                }
            }
        }
    }
}