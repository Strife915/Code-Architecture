using UnityEngine;

namespace CodeArchitecture.Adapter
{
    public class WildTurkey : MonoBehaviour, ITurkey
    {
        public void Gobble() {
            Debug.Log("Wild turkey gobble");
        }

        public void Fly() {
            Debug.Log("Wild turkey fly");
        }
    }

    public class MallardDuck : IDuck
    {
        public void Quack() {
            Debug.Log("Mallard duck quack");
        }

        public void Fly() {
            Debug.Log("Mallard duck fly");
        }
    }

    public class TurkeyAdapter : IDuck
    {
        ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey) {
            _turkey = turkey;
        }

        public void Quack() {
            _turkey.Gobble();
        }

        public void Fly() {
            _turkey.Fly();
        }
    }
}