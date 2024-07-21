using CodeArchitecture.SimpleFactory;
using Sirenix.OdinInspector;
using UnityEngine;

namespace CodeArchitecture.FactoryMethod
{
    public class PizzaStoreClient : MonoBehaviour
    {
        [SerializeField] PizzaStoreTypes _currentStoreType;

        [Button]
        void OrderPizza(PizzaTypes pizzaType)
        {
            IPizzaStore pizzaStore = _currentStoreType switch
            {
                PizzaStoreTypes.Nyc => new NyPizzaStore(),
                PizzaStoreTypes.Chicago => new ChicagoPizzaStore(),
                _ => new NyPizzaStore()
            };

            pizzaStore.CreatePizza(pizzaType);
            pizzaStore.OrderPizza();
        }
    }
}