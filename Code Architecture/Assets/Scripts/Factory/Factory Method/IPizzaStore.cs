using CodeArchitecture.Enums;
using CodeArchitecture.SimpleFactory;

namespace CodeArchitecture.FactoryMethod
{
    public interface IPizzaStore
    {
        IPizza CreatePizza(PizzaTypes type);
        void OrderPizza(PizzaTypes pizzaType);
    }

    public abstract class PizzaStore : IPizzaStore
    {
        public abstract IPizza CreatePizza(PizzaTypes type);

        public void OrderPizza(PizzaTypes pizzaType) {
            IPizza pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}