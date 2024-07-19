using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Utilities;

namespace CodeArchitecture.Mediator
{
    public abstract class Mediator<T> : MonoBehaviour where T : Component, IVisitable
    {
        readonly List<T> _entities = new List<T>();

        public void Register(T entity)
        {
            if (!_entities.Contains(entity))
            {
                _entities.Add(entity);
                OnRegistered(entity);
            }
        }

        public void Unregister(T entity)
        {
            if (_entities.Contains(entity))
            {
                _entities.Remove(entity);
                OnUnRegistered(entity);
            }
        }

        public void Message(T source, T target, IVisitor message)
        {
            _entities.FirstOrDefault(entity => entity.Equals(target))?.Accept(message);
        }

        public void BroadCast(T source, IVisitor message, Func<T, bool> predicate = null)
        {
            _entities.Where(target =>
                    source != target && SenderConditionMet(target, predicate) && MediatorConditionMet(target))
                .ForEach(target => target.Accept(message));
        }

        bool SenderConditionMet(T target, Func<T, bool> predicate) => predicate == null || predicate(target);
        protected abstract bool MediatorConditionMet(T target);

        protected virtual void OnRegistered(T entity)
        {
            //noop
        }

        protected virtual void OnUnRegistered(T entity)
        {
            //noop
        }
    }

    public interface IVisitor
    {
        void Visit<T>(T visitable) where T : Component, IVisitable;
    }

    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}