using System;
using System.Collections.Generic;
using UnityEngine;

namespace CodeArchitecture.Observer
{
    public class PlayerMoney : MonoBehaviour, ISubject
    {
        public int Money { get; private set; }
        List<IObserver> _observers = new List<IObserver>();

        public void AddMoney(int amount)
        {
            Money += amount;
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                _observers[i].UpdateObserver(Money);
            }
        }

        void Update()
        {
            Debug.Log("Update called");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AddMoney(100);
            }
        }
    }
}