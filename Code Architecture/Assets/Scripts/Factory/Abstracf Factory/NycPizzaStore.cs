using CodeArchitecture.Enums;
using UnityEngine;

namespace CodeArchitecture.Abstract.Factory
{
    public class NycPizzaStore : IPizzaStore
    {
        public IPizza CreatePizza(PizzaTypes type) {
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            switch (type)
            {
                case PizzaTypes.Cheese:
                    IPizza pizza = new CheesePizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
                case PizzaTypes.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
                case PizzaTypes.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
                case PizzaTypes.Veggie:
                    pizza = new VeggiePizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
                default:
                    pizza = new CheesePizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
            }
        }

        public void OrderPizza(PizzaTypes type) {
            CreatePizza(type);
        }
    }

    public class ChicagoPizzaStore : IPizzaStore
    {
        public IPizza CreatePizza(PizzaTypes type) {
            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            IPizza pizza = null;
            switch (type)
            {
                case PizzaTypes.Cheese:
                    pizza = new CheesePizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
                case PizzaTypes.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
                case PizzaTypes.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
                case PizzaTypes.Veggie:
                    pizza = new VeggiePizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
                default:
                    pizza = new CheesePizza(ingredientFactory);
                    Debug.Log(pizza.Name);
                    return pizza;
            }
        }

        public void OrderPizza(PizzaTypes type) {
            CreatePizza(type);
        }
    }
}