using CodeArchitecture.Enums;
using Sirenix.OdinInspector;
using UnityEngine;

namespace CodeArchitecture.SimpleFactory
{
    public class PizzaStoreClient : MonoBehaviour
    {
        [Button]
        public void OrderPizza(PizzaTypes pizzaTypes) {
            var pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza(pizzaTypes);
        }
    }
}