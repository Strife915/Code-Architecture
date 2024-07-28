using CodeArchitecture.Enums;
using Sirenix.OdinInspector;
using UnityEngine;

namespace CodeArchitecture.Abstract.Factory
{
    public class AbstractFactoryUser : MonoBehaviour
    {
        [SerializeField] PizzaStoreTypes _currentStoreType;

        [Button]
        void OrderPizza(PizzaTypes pizzaType) {
            IPizzaStore pizzaStore = _currentStoreType switch
            {
                PizzaStoreTypes.Nyc => new NycPizzaStore(),
                PizzaStoreTypes.Chicago => new ChicagoPizzaStore(),
                _ => new NycPizzaStore()
            };

            pizzaStore.OrderPizza(pizzaType);
        }
    }
}