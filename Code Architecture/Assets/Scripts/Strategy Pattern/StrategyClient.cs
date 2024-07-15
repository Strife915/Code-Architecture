using System;
using UnityEngine;
using Zenject;

namespace CodeArchitecture.Strategy
{
    public class StrategyClient : MonoBehaviour
    {
        DuckBase _mallardDuck;
        DuckBase _rubberDuck;

        [Inject]
        public void Construct(MallardDuck mallardDuck, RubberDuck rubberDuck)
        {
            _mallardDuck = mallardDuck;
            _rubberDuck = rubberDuck;
        }

        void Start()
        {
            _mallardDuck.PerformFly();
            _mallardDuck.PerformQuack();
            _rubberDuck.PerformFly();
            _rubberDuck.PerformQuack();
        }
    }
}