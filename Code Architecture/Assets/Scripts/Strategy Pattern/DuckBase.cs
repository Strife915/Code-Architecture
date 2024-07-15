using UnityEngine;
using Zenject;

namespace CodeArchitecture.Strategy
{
    public abstract class DuckBase
    {
        protected IFlyBehaviour _flyBehaviour;
        protected IQuackBehaviour _quackBehaviour;

        [Inject]
        public DuckBase(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            _flyBehaviour = flyBehaviour;
            _quackBehaviour = quackBehaviour;
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            _flyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            _quackBehaviour = quackBehaviour;
        }

        public void PerformFly()
        {
            _flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            _quackBehaviour.Quack();
        }

        public abstract void Display();
    }

    public class MallardDuck : DuckBase
    {
        public override void Display()
        {
            Debug.Log("I'm a Mallard Duck");
        }

        public MallardDuck(FlyWithWings flyBehaviour, RegularQuack quackBehaviour) : base(flyBehaviour, quackBehaviour)
        {
        }
    }

    public class RubberDuck : DuckBase
    {
        public RubberDuck(FlyNoWay flyBehaviour, Squeak quackBehaviour) : base(flyBehaviour, quackBehaviour)
        {
        }

        public override void Display()
        {
            Debug.Log("I'm a Rubber Duck");
        }
    }

    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Debug.Log("I'm flying with wings");
        }
    }

    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Debug.Log("I can't fly");
        }
    }

    public class RegularQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Debug.Log("Quack");
        }
    }

    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Debug.Log("Squeak");
        }
    }

    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Debug.Log("I can't quack");
        }
    }

    public interface IFlyBehaviour
    {
        void Fly();
    }

    public interface IQuackBehaviour
    {
        void Quack();
    }
}