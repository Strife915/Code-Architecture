using System.Collections.Generic;
using UnityEngine;

namespace CodeArchitecture.Adapter
{
    public class AdapterUser : MonoBehaviour
    {
        IDuck _mallardDuck;
        IDuck _turkey;
        IList<IDuck> _ducks = new List<IDuck>();

        void Awake() {
            _mallardDuck = new MallardDuck();
            _turkey = new TurkeyAdapter(new WildTurkey());
            _ducks.Add(_mallardDuck);
            _ducks.Add(_turkey);
        }

        void Start() {
            foreach (var duck in _ducks)
            {
                duck.Quack();
                duck.Fly();
            }
        }
    }
}